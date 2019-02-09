using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public static class MyDriver
    {
         static IWebDriver driver ;

        public static IWebDriver Driver
        {
            get => driver;
            set => driver = value;
        }

    }
}
