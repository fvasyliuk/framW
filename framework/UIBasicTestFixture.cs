using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public class UIBasicTestFixture
    {

        public void GoToUrl(string url)
        {
            MyDriver.Driver = new ChromeDriver();
            MyDriver.Driver.Navigate().GoToUrl(url);
        }

        public void Quit()
        {
            MyDriver.Driver.Quit();
        }
    }
}
