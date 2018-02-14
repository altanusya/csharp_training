using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressdookTests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {

        [SetUp]
        public void InitApplicartionManafer()
        {
            ApplicationManager app = ApplicationManager.GetInstance();
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }
    }
}
