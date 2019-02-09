using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.components
{
    public class Button:Component
    {
        public Button(By locator) : base(locator)
        {
            
        }

        public Button Click()
        {
            WebElement.Click();
            return this;

        }
    }

   
}
