using System;
using System.Diagnostics.CodeAnalysis;
using FakeXrmEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Plugins;
using PluginTests.ProxyClasses;

namespace PluginTests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void EventCreate()
        {
            var context = new XrmFakedContext();

            var inputParameters = new ParameterCollection {{"Target", new Event()}};

            var plugCtx = context.GetDefaultPluginContext();
            plugCtx.MessageName = "Create";
            plugCtx.Stage = 40;
            plugCtx.InputParameters = inputParameters;

            try
            {
                context.ExecutePluginWith<EventCreateUpdate>(plugCtx);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void EventUpdate()
        {
            var context = new XrmFakedContext();

            var inputParameters = new ParameterCollection { { "Target", new Event() } };

            var plugCtx = context.GetDefaultPluginContext();
            plugCtx.MessageName = "Update";
            plugCtx.Stage = 40;
            plugCtx.InputParameters = inputParameters;

            try
            {
                context.ExecutePluginWith<EventCreateUpdate>(plugCtx);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void EventWrongMessage()
        {
            var context = new XrmFakedContext();

            var inputParameters = new ParameterCollection { { "Target", new Event() } };

            var plugCtx = context.GetDefaultPluginContext();
            plugCtx.MessageName = "Delete";
            plugCtx.Stage = 40;
            plugCtx.InputParameters = inputParameters;

            try
            {
                context.ExecutePluginWith<EventCreateUpdate>(plugCtx);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void EventWrongStage()
        {
            var context = new XrmFakedContext();

            var inputParameters = new ParameterCollection { { "Target", new Event() } };

            var plugCtx = context.GetDefaultPluginContext();
            plugCtx.MessageName = "Create";
            plugCtx.Stage = 20;
            plugCtx.InputParameters = inputParameters;

            try
            {
                context.ExecutePluginWith<EventCreateUpdate>(plugCtx);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}