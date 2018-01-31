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
    public class GroupCreationTests : TestBase
    {      
        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupPage();
            app.Groups.InitGroupCreation();
            GroupData group = new GroupData("AAA");
            group.Footer = "fff";
            group.Header = "ddd";
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitGroupCreation();
            app.Groups.ReturToGroupPage();
        }        
    }
}
