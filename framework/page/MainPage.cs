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
    public class MainPage:Page
    {
        By linkAboutUS = By.XPath("//ul[@class='menu reset']//li/a[contains(text(),'About Us')]");
        By linkCompanyFromMainMenu = By.XPath("//span[contains(text(),'Company')]");
        By buttonCloseStartingAlert = By.Id("onesignal-popover-cancel-button");
        By linkLogin = By.XPath("//a[@class='login']");
        



        public MainPage CloseAlertWindows()
        {
            var wait = new Wait().Explicit(5000);
            wait.Until(ExpectedConditions.ElementIsClickable(buttonCloseStartingAlert));            
            new Button(buttonCloseStartingAlert).Click();
            wait.Until(ExpectedConditions.ElementIsClickable(By.XPath("//div[@id='PopupSignupForm_0']//div[@class='mc-closeModal']")));
            new Button(By.XPath("//div[@id='PopupSignupForm_0']//div[@class='mc-closeModal']")).Click();

            return this;
        }

        public void ClickLinAboutUSk()
        {
            var actions = new Actions(MyDriver.Driver);
            actions.MoveToElement(MyDriver.Driver.FindElement(linkCompanyFromMainMenu)).Perform();          
            new Link(linkAboutUS).Click();
        }

        public LoginPage GoToLoginPage()
        {
            new Wait().Implicit(5000);
            new Link(linkLogin).Click();
            MyDriver.Driver.SwitchTo().Window(MyDriver.Driver.WindowHandles[1]);
            return new LoginPage();
        }


    }
}
