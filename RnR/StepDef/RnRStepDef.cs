using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RnR
{
    [Binding]
    public sealed class RnRStepDef
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public RnRStepDef(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"(.*) logs in")]
        public void GivenLogsIn(string p0, Table table)
        {
            Util details = table.CreateInstance<Util>();
            //Headless chrome
            /*var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            PropertiesCollection.driver = new ChromeDriver(chromeOptions);*/
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl(details.URL);
            SetMethods.PageLoadTimeout(20);
            PropertiesCollection.driver.Manage().Window.Maximize();
        }

        [Given(@"Lands on the (.*)")]
        public void GivenLandsOnThe(string p0, Table table)
        {
            context.Pending();
        }

        [When(@"User clicks on Active resignees")]
        public void WhenUserClicksOnActiveResignees()
        {
            context.Pending();
        }

        [Then(@"User is directed to the HR ops dashboard")]
        public void ThenUserIsDirectedToTheHROpsDashboard()
        {
            context.Pending();
        }

        [Given(@"A valid HR Ops user")]
        public void GivenAValidHROpsUser()
        {
            context.Pending();
        }
    }
}
