﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressdookTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(IWebDriver driver, string baseURL) : base (driver)
        {
            this.baseURL = baseURL;
        }

        public void GoToGroupPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
      
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/group.php");
        }

       
    }

 }
