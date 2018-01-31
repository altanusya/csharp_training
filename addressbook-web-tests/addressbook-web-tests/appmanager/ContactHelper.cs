using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressdookTests
{
    public class ContactHelper : HelperBase
    {
       
        public ContactHelper(IWebDriver driver) : base(driver)
        {
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
