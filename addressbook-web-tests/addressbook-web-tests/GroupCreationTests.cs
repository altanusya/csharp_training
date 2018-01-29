﻿using System;
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
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupPage();
            InitGroupCreation();
            GroupData group = new GroupData("AAA");
            group.Footer = "fff";
            group.Header = "ddd";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturToGroupPage();
        }        
    }
}
