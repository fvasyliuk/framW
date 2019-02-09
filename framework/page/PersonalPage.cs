using framework.components;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.page
{
    public class PersonalPage
    {
        By fullName = By.XPath("//div[@class='panel-body']//em");
        By updateLink = By.XPath("//a[@class='btn btn-success btn-sm btn-block']");
        By firstName = By.Id("inputFirstName");
        By saveChanges = By.Name("save");
        By homeLink = By.XPath("//li[@id='Primary_Navbar-Home']//a[contains(text(),'Home')]");

        public string FullNameText()
        {
            return MyDriver.Driver.FindElement(fullName).Text;
        }

        public void EditName(string name)
        {
            new Link(updateLink).Click();
            new Input(firstName).SendKeys(name);
            new Button(saveChanges).Click();
            new Link(homeLink).Click();
        }


    }
}
