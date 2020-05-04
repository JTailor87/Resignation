using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RnR.ComponentHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnR.PageObjectMethods
{
    class AccessTokenPageObjects
    {
        [Obsolete]
        public AccessTokenPageObjects()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
            //this.driver = _driver;
        }
        [FindsBy(How = How.Id, Using = "AccessToken")]
        public IWebElement AccessToken { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        public IWebElement Continue { get; set; }

        [Obsolete]
        public void EnterAccessTokenAndConti()
        {
            SetMethods.PageLoadTimeout(20);
            SetMethods.WaitElementExists(20, "Id", "AccessToken");
            AccessToken.EnterText(GetOTPHelper.GetOtpForUser("32d812dab6@emailtown.club"));
            Continue.Clicks();
        }
    }
}
