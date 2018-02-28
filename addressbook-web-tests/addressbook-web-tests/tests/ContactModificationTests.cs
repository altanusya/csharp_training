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

            app.Contacts.CheckPresence();
            app.Contacts.Modify(1, data);
        
        }

       
    }
}
