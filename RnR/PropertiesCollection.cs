using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnR
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName,
        Xpath,
        Accept,
        Cancel
    }
    public class PropertiesCollection
    {
        //Auto-implemented Property
        public static IWebDriver driver { get; set; }
    }
}
