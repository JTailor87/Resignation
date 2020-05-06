using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnR.PageObjectMethods
{
    class LandingPageObjects
    {
        [Obsolete]
        public LandingPageObjects()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
            //this.driver = _driver;
        }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'resignees')]")]
        public IWebElement ActiveResignees { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='name - btn']/text()")]
        public IWebElement User { get; set; }

        public string GetPageTitle()
        {
            SetMethods.PageLoadTimeout(20);
            String title = PropertiesCollection.driver.Title;
            return title;
        }

        [Obsolete]
        public void ClickOnActiveResignees()
        {
            SetMethods.WaitElementExists(20, ActiveResignees);
            ActiveResignees.Clicks();
        }
        public string UserIsOnResignationDashboard()
        {
            SetMethods.PageLoadTimeout(20);
            String title = PropertiesCollection.driver.Title;
            return title;
        }
        public string ValidHROpsUserLoggedIn()
        {
            return User.GetText();
            //SetMethods.HowmanyIFrames();
        }
    }
}
