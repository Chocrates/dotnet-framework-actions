using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Tests
{
    [TestClass()]
    public class AddTests
    {
        [TestMethod()]
        public void addTest()
        {
            Add add = new Add();
            Assert.AreEqual(4, add.add(1, 3));
        }
    }
}