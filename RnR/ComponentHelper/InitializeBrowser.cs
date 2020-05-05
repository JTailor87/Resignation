using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace RnR.ComponentHelper
{
    public static class InitializeBrowser
    {
        public static void BrowserName(String browserName, String mode)
        {
            if (browserName == "Chrome" && mode == "Normal")
            {
                ChromeDriverService service = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                service.SuppressInitialDiagnosticInformation = true;
                PropertiesCollection.driver = new ChromeDriver(service);
                PropertiesCollection.driver.Manage().Window.Maximize();
            }
            else if (browserName == "Chrome" && mode == "Headless")
            {
                var chromeOptions = new ChromeOptions();
                ChromeDriverService service = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                service.SuppressInitialDiagnosticInformation = true;
                chromeOptions.AddArguments("headless");
                PropertiesCollection.driver = new ChromeDriver(service, chromeOptions);
                PropertiesCollection.driver.Manage().Window.Maximize();
            }
            else if (browserName == "IE" && mode == "Normal")
            {
                InternetExplorerDriverService service = InternetExplorerDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                service.SuppressInitialDiagnosticInformation = true;
                PropertiesCollection.driver = new InternetExplorerDriver(service);
                PropertiesCollection.driver.Manage().Window.Maximize();
            }
            else if (browserName == "Edge" && mode == "Normal")
            {
                PropertiesCollection.driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            }
            else if (browserName == "Edge" && mode == "Headless")
            {
                EdgeDriverService edgeDriverService = EdgeDriverService.CreateDefaultService();
                edgeDriverService.HideCommandPromptWindow = true;
                edgeDriverService.SuppressInitialDiagnosticInformation = true;
                PropertiesCollection.driver = new EdgeDriver(edgeDriverService);
            }
        }
    }
}
