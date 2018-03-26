using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressdookTests.tests
{
    [TestFixture]
    class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.CheckPresence();           
            app.Contacts.Remove(2);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.RemoveAt(1);

            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
