using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnR.PageObjectMethods
{
    class LoginPageObjects
    {
        [Obsolete]
        public LoginPageObjects()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
            //this.driver = _driver;
        }
        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement Username { get; set; }
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        public IWebElement Login { get; set; }

        [Obsolete]
        public void LoginPage(String username, String password)
        {
            SetMethods.ImplicitlyWait(10);
            SetMethods.WaitElementExists(30, "Id", "Username");
            Username.EnterText(username);
            Password.EnterText(password);
            Login.Clicks();
        }
    }
}
