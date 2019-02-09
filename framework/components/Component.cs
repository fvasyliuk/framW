using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public class Component
    {
       public IWebElement webElement;
       public Component(By locator):base()
       {
            this.WebElement = MyDriver.Driver.FindElement(locator);
       }

        public IWebElement WebElement
        {
            get => webElement;
            set => webElement = value;
        }


    }
}
