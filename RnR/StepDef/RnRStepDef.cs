using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RnR.ComponentHelper;
using RnR.PageObjectMethods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RnR
{
    [Binding]
    public sealed class RnRStepDef
    {
        [Obsolete]
        LoginPageObjects login;
        [Obsolete]
        AccessTokenPageObjects AccessToken;
        [Obsolete]
        LandingPageObjects landingPage;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public RnRStepDef(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"(.*) logs in")]
        [Obsolete]
        public void GivenLogsIn(string p0, Table table)
        {
            Util details = table.CreateInstance<Util>();

            InitializeBrowser.BrowserName("Chrome", "Normal");

            PropertiesCollection.driver.Navigate().GoToUrl(details.URL);
            SetMethods.PageLoadTimeout(20);

            login = new LoginPageObjects();
            login.LoginPage(details.Email, details.Password);

            AccessToken = new AccessTokenPageObjects();
            AccessToken.EnterAccessTokenAndConti();
        }

        [Given(@"Lands on the (.*)")]
        [Obsolete]
        public void GivenLandsOnThe(string p0, Table table)
        {
            landingPage = new LandingPageObjects();
            Console.WriteLine(landingPage.GetPageTitle());
        }

        [When(@"User clicks on Active resignees")]
        [Obsolete]
        public void WhenUserClicksOnActiveResignees()
        {
            landingPage = new LandingPageObjects();
            landingPage.ClickOnActiveResignees();
        }

        [Then(@"User is directed to the HR ops dashboard")]
        [Obsolete]
        public void ThenUserIsDirectedToTheHROpsDashboard()
        {
            landingPage = new LandingPageObjects();
            String title = landingPage.UserIsOnResignationDashboard();
            Assert.AreEqual(title, "Home", "Strings are not matching");
            Console.WriteLine(title);
        }
 
        [Then(@"Close the browser")]
        public void ThenCloseTheBrowser()
        {
            PropertiesCollection.driver.Quit();
        }

    }
}
