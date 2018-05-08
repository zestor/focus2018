using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security;
using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample
{
    [Binding]
    public sealed class CreateContactSpecFlowSteps
    {
        private readonly SecureString _password = ConfigurationManager.AppSettings["OnlinePassword"].ToSecureString();
        private readonly SecureString _username = ConfigurationManager.AppSettings["OnlineUsername"].ToSecureString();
        private readonly Uri _xrmUri = new Uri(ConfigurationManager.AppSettings["OnlineCrmUrl"]);

        private Api.Browser _xrmBrowser;

        [BeforeScenario]
        public void Setup()
        {
            _xrmBrowser = new Api.Browser(TestSettings.Options);
        }

        [AfterScenario]
        public void TearDown()
        {
            _xrmBrowser.Dispose();
        }

        [Given("user logs into dynamics 365 sales")]
        public void GivenUserLogsIntoDynamics365Sales()
        {
            _xrmBrowser.LoginPage.Login(_xrmUri, _username, _password);
            _xrmBrowser.GuidedHelp.CloseGuidedHelp();
            _xrmBrowser.ThinkTime(200);
        }

        [Given("navigates subarea (.*) then (.*)")]
        public void GivenNavigatesSubArea(string area, string subarea)
        {
            _xrmBrowser.Navigation.OpenSubArea(area, subarea);
            _xrmBrowser.ThinkTime(200);
        }

        [Given("switches grid view to (.*)")]
        public void GivenSwitchesGridView(string viewname)
        {
            _xrmBrowser.Grid.SwitchView(viewname);
            _xrmBrowser.ThinkTime(200);
        }

        [Given("clicks (.*) button on the ribbon")]
        public void GivenClicksButtonOnTheRibbon(string buttonname)
        {
            _xrmBrowser.CommandBar.ClickCommand(buttonname);
            _xrmBrowser.ThinkTime(200);
        }

        [Given("enters firstname (.*) and lastname (.*) in (.*) field of type fullname")]
        public void EntersFullnameField(string firstname, string lastname, string fieldname)
        {
            var fields = new List<Field>
            {
                new Field {Id = "firstname", Value = firstname},
                new Field {Id = "lastname", Value = lastname}
            };
            _xrmBrowser.Entity.SetValue(new CompositeControl {Id = fieldname, Fields = fields});
        }


        [Given("enters (.*) in (.*) field of type string")]
        public void EntersStringField(string value, string fieldname)
        {
            _xrmBrowser.Entity.SetValue(fieldname, value);
        }

        [Given("enters (.*) in (.*) field of type datetime")]
        public void EntersDateTimeField(string value, string fieldname)
        {
            _xrmBrowser.Entity.SetValue(fieldname, DateTime.Parse(value));
        }

        [Given("enters (.*) in (.*) field of type optionset")]
        public void EntersOptionSetField(string value, string fieldname)
        {
            _xrmBrowser.Entity.SetValue(new OptionSet {Name = fieldname, Value = value});
        }

        [When("clicks (.*) button on the ribbon awesome")]
        public void WhenClicksButtonOnTheRibbon(string buttonname)
        {
            _xrmBrowser.CommandBar.ClickCommand(buttonname);
            _xrmBrowser.ThinkTime(200);
        }

        [Then("form should reload")]
        public void FormShouldReload()
        {
        }

        [Then("user should see (.*) field of type string is (.*)")]
        public void TestsStringField(string fieldname, string testvalue)
        {
            string formvalue = _xrmBrowser.Entity.GetValue(fieldname);
            Assert.AreEqual(testvalue.ToLower().Trim(), formvalue.ToLower().Trim());
        }
    }
}