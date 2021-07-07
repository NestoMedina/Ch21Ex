using Microsoft.VisualStudio.TestTools.UnitTesting;
using ch21Ex;

namespace TechnologyTests
{
    [TestClass]
    public class SmartPhoneTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            SmartPhone test1 = new SmartPhone("Android", "Samsung", 5.6);
            Assert.AreEqual(test1.OSName, "Android");
        }

        [TestMethod]
        public void TestScreenSize()
        {
            SmartPhone test1 = new SmartPhone("Android", "Samsung", 5.6);
            Assert.AreEqual(test1.Screensize, 5.6);
            
        }

    }
}
