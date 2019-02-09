using framework.components;
using framework.page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace framework
{
    [TestFixture]
    class UITest: UIBasicTestFixture
    {
        

        [Test, Order(1)]
        public void TEstURLAboutUsPage()
        {
            GoToUrl("https://phptravels.com/");

            new MainPage()
                .CloseAlertWindows()
                .ClickLinAboutUSk();

            Assert.That("https://phptravels.com/about-us/", Is.EqualTo(MyDriver.Driver.Url));

            Quit();

        }

        [Test, Order(2)]
        public void TestFullNameAfterLogin()
        {
            GoToUrl("https://phptravels.com/");

            new MainPage()
                .CloseAlertWindows()
                .GoToLoginPage()
                .Login();

            string fullName = new PersonalPage().FullNameText();
            Assert.That("Homer Prosto", Is.EqualTo(fullName));
            Quit();
            
        }

        [Test, Order(3)]
        public void EditName()
        {
            string name = "Homer";

            GoToUrl("https://phptravels.org/clientarea.php");

            new LoginPage().Login();
                

            PersonalPage Person = new PersonalPage();
            Person.EditName(name);

            string fullName = Person.FullNameText();
            Assert.That($"{name} Prosto", Is.EqualTo(fullName));
            Quit();
        }

    }
}
