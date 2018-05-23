using System;
using Microsoft.Crm.Sdk.Samples;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;

namespace UpdateCRMSolutionVersion
{
    public class CustomCode
    {
        private OrganizationServiceProxy _serviceProxy;

        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            using (_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig))
            {
                _serviceProxy.EnableProxyTypes();

                Entity orgA = QueryOrg(); //  Default value 5242880

                orgA.Attributes.Add("maxuploadfilesize", 0);
                _serviceProxy.Update(orgA);

                Entity orgB = QueryOrg(); // should show our new value 0

                // set it back to default
                orgB.Attributes.Add("maxuploadfilesize", 5242880);
                _serviceProxy.Update(orgB);

                Console.WriteLine("");
            }
        }

        public Entity QueryOrg()
        {
            Entity org = null;

            string MaxUploadFileSizeFieldName = "maxuploadfilesize";

            var qe = new QueryExpression("organization")
            {
                ColumnSet = new ColumnSet(true)
            };

            var solutionResults = _serviceProxy.RetrieveMultiple(qe);

            if (solutionResults.Entities.Count == 1)
            {
                org = solutionResults.Entities[0];

                foreach(string key in org.Attributes.Keys)
                {
                    Console.WriteLine("{0} = {1}", key, org.Attributes[key]);
                }


                int MaxUploadFileSizeValue = org.GetAttributeValue<int>("maxuploadfilesize");

                if (org.Attributes.Contains(MaxUploadFileSizeFieldName))
                {
                    org.Attributes.Remove(MaxUploadFileSizeFieldName);
                }

                Console.WriteLine("MaxUploadFileSize: {0}", MaxUploadFileSizeValue);
            }
            else
            {
                Console.WriteLine("Did not find 1 organization");
            }

            return org;
        }

    }
}