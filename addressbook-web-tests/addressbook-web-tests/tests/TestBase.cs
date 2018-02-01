﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressdookTests
{
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        protected void SetupTest()
        {
            app = new ApplicationManager();

            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        protected void TeardownTest()
        {
            app.Stop();
        }
    }
}