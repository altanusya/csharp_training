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
       
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }

        public ContactHelper Create(ContactData account)
        {
            manager.Navigator.GoToHomePage();

            AddNewContact();
            FillContactForm(account);
            SubmitContactCreation();
            manager.Navigator.GoToHomePage();

            return this;
        }

        public ContactHelper Remove(int v)
        {
            manager.Navigator.GoToHomePage();
            
            SelectContact(v);
            DeleteContact();
            ApproveDeleting();
            manager.Navigator.GoToHomePage();

            return this;
        }

        public List<ContactData> GetContactList()
        {
            List<ContactData> contacts = new List<ContactData>();
            manager.Navigator.GoToHomePage();
            ICollection<IWebElement> elements = driver.FindElements(By.XPath("//table[@id='maintable']/tbody/tr[position()>1]"));
            foreach (IWebElement element in elements)
            {
                string fullName = element.Text;
                if (fullName != "")
                {
                    string[] names = fullName.Split(' ');
                    string lastName = names[0];
                    string firstName = names[1];
                    contacts.Add(new ContactData(firstName, lastName));
                }
                else
                {
                    contacts.Add(new ContactData("", ""));
                }
            }
            return contacts;
        }

        public bool PresenceElement()
        {
            return IsElementPresent(By.XPath("(//img[@alt='Edit'])[1]")); 
        }

        public void CheckPresence()
        {
            ContactData acc = new ContactData("Elena", "Gosh");

            if (!PresenceElement())
            {
                Create(acc);
            }
        }

        public ContactHelper Modify(int v, ContactData data)
        {
            manager.Navigator.GoToHomePage();

            InitContactModification(v);
            FillContactForm(data);
            SubmitContactModification();
            manager.Navigator.GoToHomePage();
            return this;
        }

        public ContactHelper ApproveDeleting()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public ContactHelper DeleteContact()
        {
            driver.FindElement(By.XPath("html/body/div[1]/div[4]/form[2]/div[2]/input")).Click();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            index++;
            driver.FindElement(By.XPath("//*[@id='maintable']/tbody/tr["+index+"]/td[1]")).Click();
            return this;
        }
        

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper InitContactModification(int index)
        {
            
            driver.FindElement(By.XPath("(//img[@alt='Edit'])["+index+"]")).Click();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Name);
            Type(By.Name("lastname"), contact.LastName);
            return this;
        }

        
        public ContactHelper AddNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
    }
}
