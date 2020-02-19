using CodeCoverageTestLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 calculator = new Class1();
            int i1 = 2;
            int i2 = 3;

            int result = calculator.Add(i1, i2);

            Assert.AreEqual(i1 + i2, result);
        }
    }
}
