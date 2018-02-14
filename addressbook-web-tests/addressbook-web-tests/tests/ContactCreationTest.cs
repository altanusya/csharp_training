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
    public class ContactCreationTests : AuthTestBase
    {
       
       [Test]
        public void ContactCreationTest()
        {
            ContactData data = new ContactData("John", "Doe");            

            app.Contacts.Create(data);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData data = new ContactData("", "");

            app.Contacts.Create(data);
        }
    }
}
