using System;
using System.ComponentModel;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Plugins.ProxyClasses;

namespace Plugins
{
    public class EventCreateUpdate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var context = (IPluginExecutionContext)
                serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                var entity = (Entity) context.InputParameters["Target"];

                if (entity.LogicalName != "ccc_event")
                    throw new ArgumentException("Not registered for ccc_event");

                // Post-Event Stage in the pipeline for plug-ins which are to execute 
                // after the main operation. Plug-ins registered in this stage are 
                // executed within the database transaction.
                if (context.Stage != 40)
                    throw new ArgumentException("Not registered for stage 40");

                if (context.MessageName.ToLower() != "create" && context.MessageName.ToLower() != "update")
                    throw new ArgumentException("Not registered for create or update");

                //EventLog e = null;
                //if (DateTime.Now.Ticks == 123)
                //{
                //    e = new EventLog();
                //}
                //Console.WriteLine(e.Name);

                try
                {
                    var serviceFactory =
                        (IOrganizationServiceFactory) serviceProvider.GetService(typeof(IOrganizationServiceFactory));

                    var service = serviceFactory.CreateOrganizationService(context.UserId);

                   //throw new InvalidOperationException("you have invoked invalid method");

                    var eventLog = new EventLog {Name = entity.GetAttributeValue<string>("ccc_name")};

                    service.Create(eventLog);
                }
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An error occurred in the plug-in.", ex);
                }
            }
        }
    }
}