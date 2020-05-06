using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoIt;

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

        public static void HowmanyIFrames()
        {
            List<IWebElement> frames = new List<IWebElement>(PropertiesCollection.driver.FindElements(By.TagName("iframe")));
            Console.WriteLine("Number of Frames: " + frames.Count);
            for (int i = 0; i < frames.Count; i++)
            {
                Console.WriteLine("frame[" + i + "]: " + frames[i].GetAttribute("id").ToString());
            }
        }
        public static void ScrollById(String ID)
        {
            var element = PropertiesCollection.driver.FindElement(By.Id(ID));
            Actions actions = new Actions(PropertiesCollection.driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public static void Alert(String Action)
        {
            if (Action == "Accept")
            {
                try
                {
                    IAlert alert = PropertiesCollection.driver.SwitchTo().Alert();
                    Console.WriteLine(alert.Text);
                    alert.Accept();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else if (Action == "Cancel")
            {
                try
                {
                    IAlert alert = PropertiesCollection.driver.SwitchTo().Alert();
                    Console.WriteLine(alert.Text);
                    alert.Dismiss();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public static void AutoITUpload(String windowsName, String filePath)
        {
            /* AutoItX3 autoIt = new AutoItX3();*/
            //Open - is depend upon your browser i.e. for firefox it is "File Upload"
            AutoItX.WinActivate(windowsName);
            Thread.Sleep(1000);
            AutoItX.Send(@filePath);
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");
        }

        [Obsolete]
        public static void WaitElementExists(double Time, IWebElement webElement)
        {
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(Time));
            wait.Until(ExpectedConditions.ElementToBeClickable(webElement));
        }
    }
}
