using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SautinSoft.Document;
using SautinSoft.Document.Drawing;
using System.Globalization;
using OpenQA.Selenium;
using System.IO;

namespace Microsoft.Dynamics365.UIAutomation.Sample
{
    public static class AutoDocGen
    {
        public static bool Enabled = false;
        public static IWebDriver WebDriver;
        static DocumentCore dc = new DocumentCore();
        static Section s;
        static Paragraph par;
        static TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        public static void BeforeFeature()
        {
            if (Enabled)
            {
                s = new Section(dc);
                s.PageSetup.PageMargins.Left = 5;
                s.PageSetup.PageMargins.Right = 5;
                s.PageSetup.PageMargins.Top = 5;
                s.PageSetup.PageMargins.Bottom = 5;

                dc.Sections.Add(s);

                par = new Paragraph(dc);
                par.ParagraphFormat.Alignment = HorizontalAlignment.Left;
                string featureTitle = TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title;
                string featureDesc = TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Description;

                par.Content.End.Insert("Feature: " + textInfo.ToTitleCase(featureTitle), new CharacterFormat() { FontName = "Arial", Size = 28.0, FontColor = Color.Black });
                par.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));
                par.Content.End.Insert(featureDesc, new CharacterFormat() { FontName = "Arial", Size = 16.0, FontColor = Color.Black });
                par.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));
                par.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));

                s.Blocks.Add(par);
            }
        }

        public static void BeforeScenario()
        {
            if (Enabled)
            {
                string scenarioTitle = TechTalk.SpecFlow.ScenarioContext.Current.ScenarioInfo.Title;
                par.Content.End.Insert("Scenario: " + textInfo.ToTitleCase(scenarioTitle), new CharacterFormat() { FontName = "Arial", Size = 20.0, FontColor = Color.Blue });
                par.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));
                par.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));
            }
        }

        public static void BeforeStep()
        {
            if (Enabled)
            {
                string stepText = TechTalk.SpecFlow.ScenarioStepContext.Current.StepInfo.Text;
                string stepDefText = TechTalk.SpecFlow.ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                par.Content.End.Insert(stepDefText + " " + textInfo.ToTitleCase(stepText), new CharacterFormat() { FontName = "Arial", Size = 16.0, FontColor = Color.Black });
                par.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.LineBreak));
            }
        }

        public static void AfterStep()
        {
            if (Enabled)
            {
                Screenshot ss = ((ITakesScreenshot)WebDriver).GetScreenshot();
                Picture pict1 = new Picture(dc,
                    InlineLayout.Inline(new Size(576, 324)),
                    new MemoryStream(ss.AsByteArray),
                    PictureFormat.Png);
                par.Inlines.Add(pict1);
                par.Inlines.Add(new SpecialCharacter(dc, SpecialCharacterType.PageBreak));
            }
        }

        public static void AfterFeature()
        {
            if (Enabled)
            {
                string featureTitle = TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title;
                string dateTimeString = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " " + DateTime.Now.Ticks.ToString();
                string myFilename = featureTitle + " " + dateTimeString + ".docx";
                myFilename = myFilename.Replace("/", "_").Replace(":", "_").Replace(" ", "_");
                dc.Save(@"C:\Focus2018\VSTS\CRMUG Focus 2018\AutoDoc\" + myFilename, new DocxSaveOptions());
            }
        }
    }
}
