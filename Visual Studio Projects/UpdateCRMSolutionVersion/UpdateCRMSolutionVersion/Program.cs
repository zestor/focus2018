using System;
using Microsoft.Crm.Sdk.Samples;

namespace UpdateCRMSolutionVersion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var serverConnect = new ServerConnection();
            //serverConnect.ReadConfigurations();

            var config = serverConnect.GetServerConfiguration();
            var app = new CustomCode();
            app.Run(config, true);
        }
    }
}