﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressdookTests
{
    [TestFixture]
    public class GroupModificationTests :TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz");
            newData.Footer = "rrr";
            newData.Header = "hhh";

            app.Groups.Modify(1, newData);
        }

    }
}