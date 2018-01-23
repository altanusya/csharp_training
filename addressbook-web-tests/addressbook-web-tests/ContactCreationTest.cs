using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressdookTests
{
    [TestFixture]
    public class ContactCreationTests : BaseClass
    {
        IWebDriver driver = getDriver();

       [Test]
        public void ContactCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            AddNewContact();
            FillContactForm(new ContactData("John", "Doe"));
            SubmitContactCreation();
            GoToHomePage();
        }

        private void GoToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }

        public void SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        public void FillContactForm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Name);
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contact.Middlename);
        }

        public void AddNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

    }
}
