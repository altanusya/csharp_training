using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressdookTests
{
    public class ContactData
    {
        private string firstName;
        private string middleName;
        private string lastName = "";
        private string nickname = "";
        private string title = "";
        private string company = "";
        private string address = "";
        private string telephone = "";
        private string mobile = "";
        private string workPhone = "";
        private string fax = "";
        private string email = "";
        private string email2 = "";
        private string email3 = "";
        private string homapge = "";
        private string addressSecond = "";
        private string home = "";
        private string notes = "";

        public ContactData(string name, string surname)
        {
            this.firstName = name;
            this.middleName = surname;
        }

        public string Name {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string Middlename
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }

        }
        
    }
}
