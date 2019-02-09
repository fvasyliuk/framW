using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.components
{
    public class Wait
    {
       
        public WebDriverWait Explicit(int time)
        {
            return new WebDriverWait(MyDriver.Driver, TimeSpan.FromSeconds(time));
            

        }

        public void Implicit(int time)
        {
            MyDriver.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }

        
    }
}
