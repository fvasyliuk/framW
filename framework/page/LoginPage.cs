using framework.components;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public class LoginPage
    {
        By InputEmailAddress = By.Id("inputEmail");
        By InputPassword = By.Id("inputPassword");
        By Buttonlogin = By.Id("login");

        public string password = "prosto100";
        public string email = "admina@gmail.com";

        public void Login(string email= "admina@gmail.com" , string password= "prosto100")
        {

            
                       
            new Input(InputEmailAddress).SendKeys(email);
            new Input(InputPassword).SendKeys(password);
            new Button(this.Buttonlogin).Click();

        }
    }
}
