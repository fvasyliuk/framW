using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public static class ExpectedConditions
    {
        public static Func<IWebDriver, IWebElement> ElementExists(By locator)
        {
            return driver =>
            {                
                var elements = driver.FindElements(locator);
                return (elements.Count > 0) ? elements[0] : null;
            };
        }
        public static Func<IWebDriver, IWebElement> ElementIsClickable(By locator)
        {
            return driver =>
            {
                var element = driver.FindElement(locator);
                return (element != null && element.Displayed && element.Enabled) ? element : null;
            };
        }
    }
}
