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
    public class ComputerTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            Computer test1 = new Computer("Windows", "HP", "16 GB");
            Assert.AreEqual(test1.Brand, "HP");
        }

        [TestMethod]
        public void TestField()
        {
            Computer test1 = new Computer("Windows", "HP", "16 GB");
            Assert.AreEqual(test1.RAM, "16 GB");
        }

        [TestMethod]
        public void TestMethod()
        {
            Computer test1 = new Computer("Windows", "HP", "16 GB");
            test1.UpdateOS();
            Assert.AreEqual(AbstractEntity.UpcomingUpdate, new(2022, 03, 08));
        }
    }
}
