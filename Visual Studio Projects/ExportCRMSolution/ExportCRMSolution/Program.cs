using System;
using Microsoft.Crm.Sdk.Samples;

namespace ExportCRMSolution
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var serverConnect = new ServerConnection();
            serverConnect.ReadConfigurations();

            if (args.Length < 2)
            {
                Console.WriteLine("Invalid Args....Arg[0]=CRMDomainName Arg[1]=SolutionName");
            }
            else
            {
                var crmOrg = args[0];
                var solutionName = args[1];

                var foundServerConfig = false;
                foreach (var c in serverConnect.configurations)
                {
                    if (c.ServerAddress.ToLower().Equals(crmOrg))
                    {
                        var config = serverConnect.configurations[0];

                        var app = new CustomCode(solutionName);
                        app.Run(config, true);

                        foundServerConfig = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Server domain doesn't match {0}", c.ServerAddress);
                    }
                }

                if (!foundServerConfig)
                {
                    Console.WriteLine("CRM domain name doesn't match any defined configurations");
                    var config = serverConnect.GetServerConfiguration();
                    var app = new CustomCode(solutionName);
                    app.Run(config, true);
                }
            }
        }
    }
}