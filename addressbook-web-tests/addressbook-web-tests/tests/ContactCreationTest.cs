using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace WebAddressdookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
       
       [Test]
        public void ContactCreationTest()
        {
            ContactData data = new ContactData("John", "Doe");

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(data);

            Assert.AreEqual(oldContacts.Count + 1, app.Contacts.GetContactCount());

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(data);

            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData data = new ContactData("", "");

            List<ContactData> oldContacts = app.Contacts.GetContactList();
            app.Contacts.Create(data);

            Assert.AreEqual(oldContacts.Count + 1, app.Contacts.GetContactCount());

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(data);

            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

        }
    }
}
