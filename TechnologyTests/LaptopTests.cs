using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ch21Ex;

namespace TechnologyTests
{
    [TestClass]
    public class LaptopTests
    {

        [TestMethod]
        public void TestConstructor()
        {
            Laptop test1 = new Laptop("Windows", "HP", true);
            Assert.AreEqual(test1.OSName, "Windows");
        }

        [TestMethod]
        public void TestMethod()
        {
            Laptop test1 = new Laptop("Windows", "HP", true);
            test1.ToggleTouchScreen("off");
            Assert.AreEqual(test1.touchscreen, false);
        }

        [TestMethod]
        public void TestUpdateMethod()
        {
            Laptop test1 = new Laptop("Windows", "HP", true);
            test1.UpdateOS();
            Assert.AreEqual(AbstractEntity.UpcomingUpdate, new(2022, 03, 08));
        }


    }
}
