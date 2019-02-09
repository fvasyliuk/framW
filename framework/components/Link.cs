using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public class Link:Component
    {
        public Link(By locator) : base(locator)
        {

        }

        public void Click()
        {
            WebElement.Click();
            
        }

        public string Text()
        {
            return WebElement.Text;
            
        }
    }
}
