using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnR
{
    public static class SetMethods
    {        //Enter Test
        public static void EnterText(this IWebElement element, String value)
        {
            element.SendKeys(value);
        }
        //Click on to a Button, Checkbox, Option etc.
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }
        //Selecting a Drop Down Controls
        public static void SlectDropDown(this IWebElement element, String value)
        {
            new SelectElement(element).SelectByText(value);
        }
        public static void ImplicitlyWait(double Time)
        {
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Time);
        }
        public static void PageLoadTimeout(double Time)
        {
            PropertiesCollection.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Time);
        }
    }
}
