using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.components
{
    class Input:Component
    {
        public Input(By locator) : base(locator)
        {

        }

        public Input SendKeys(string str)
        {
            WebElement.SendKeys(str);
            return this;

        }

        public Input Click()
        {
            WebElement.Click();
            return this;

        }
    }

}
