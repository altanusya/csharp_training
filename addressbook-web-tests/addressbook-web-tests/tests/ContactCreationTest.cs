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
    public class ContactCreationTests : TestBase
    {
       
       [Test]
        public void ContactCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.AddNewContact();
            app.Contacts.FillContactForm(new ContactData("John", "Doe"));
            app.Contacts.SubmitContactCreation();
            app.Navigator.GoToHomePage();
        }
    }
}
