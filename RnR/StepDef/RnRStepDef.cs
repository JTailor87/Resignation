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

            /*var chromeOptions = new ChromeOptions();
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            service.SuppressInitialDiagnosticInformation = true;
            chromeOptions.AddArguments("headless");
            PropertiesCollection.driver = new ChromeDriver(service, chromeOptions);*/
            /*Configuration.PropertiesCollection.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);*/
            /*Configuration.PropertiesCollection.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));*/
            /*Configuration.PropertiesCollection.driver = new ChromeDriver();*/
            PropertiesCollection.driver.Navigate().GoToUrl(details.URL);
            SetMethods.PageLoadTimeout(20);

            LoginPageObjects login = new LoginPageObjects();
            login.LoginPage(details.Email, details.Password);

            AccessTokenPageObjects AccessToken = new AccessTokenPageObjects();
            AccessToken.EnterAccessTokenAndConti();
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
