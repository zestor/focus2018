using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Crm.Sdk.Samples;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace ExportCRMSolution
{
    public class CustomCode
    {
        private readonly string _solutionName;

        public CustomCode(string solutionName)
        {
            _solutionName = solutionName;
        }

        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                OrganizationServiceProxy serviceProxy;

                using (serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig))
                {
                    serviceProxy.EnableProxyTypes();

                    var qe = new QueryExpression("solution")
                    {
                        ColumnSet = new ColumnSet(true)
                    };

                    qe.Criteria.AddCondition("uniquename", ConditionOperator.Equal, _solutionName);

                    var solutionResults = serviceProxy.RetrieveMultiple(qe);

                    if (solutionResults.Entities.Count > 0)
                    {
                        var solution = solutionResults.Entities.FirstOrDefault();

                        if (solution != null)
                        {
                            var oldVersionNumber = solution.GetAttributeValue<string>("version");

                            var newVersionNumber = GetNewVersion(oldVersionNumber);

                            solution.Attributes.Remove("version");
                            solution.Attributes.Add("version", newVersionNumber);

                            serviceProxy.Update(solution);

                            var exportSolutionRequest = new ExportSolutionRequest
                            {
                                Managed = false,
                                ExportAutoNumberingSettings = true,
                                ExportCalendarSettings = true,
                                ExportCustomizationSettings = true,
                                ExportEmailTrackingSettings = true,
                                //ExportExternalApplications = true,
                                ExportGeneralSettings = true,
                                ExportMarketingSettings = true,
                                ExportOutlookSynchronizationSettings = true,
                                ExportRelationshipRoles = true,
                                ExportIsvConfig = true,
                                ExportSales = true,
                                SolutionName = _solutionName
                            };

                            var exportSolutionResponse =
                                (ExportSolutionResponse) serviceProxy.Execute(exportSolutionRequest);

                            var exportXml = exportSolutionResponse.ExportSolutionFile;
                            var filename = _solutionName + "_" + newVersionNumber.Replace(".", "_") + ".zip";
                            File.WriteAllBytes(filename, exportXml);

                            Console.Write(filename);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No CRM solutions found with that name");
                        Environment.Exit(100);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0} {1}", e.Message, e.StackTrace);
                Environment.Exit(101);
            }
        }

        public string GetNewVersion(string oldVersion)
        {
            var retval = new StringBuilder();

            var versionParts = oldVersion.Split('.');

            var oldVersionNumber = int.Parse(versionParts[versionParts.Length - 1]);

            oldVersionNumber++;

            versionParts[versionParts.Length - 1] = oldVersionNumber.ToString();

            foreach (var s in versionParts)
                if (retval.Length == 0)
                    retval.Append(s);
                else
                    retval.Append(".").Append(s);

            return retval.ToString();
        }
    }
}