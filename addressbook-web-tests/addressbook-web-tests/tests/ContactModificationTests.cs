using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressdookTests.tests
{
    [TestFixture]
    public class ContactModificationTets : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData data = new ContactData("Anna", "Smith");
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.CheckPresence();
            app.Contacts.Modify(1, data);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].Name = data.Name;
            oldContacts[0].LastName = data.LastName;

            oldContacts.Sort();
            newContacts.Sort();

            Assert.AreEqual(oldContacts, newContacts);
        }

       
    }
}
