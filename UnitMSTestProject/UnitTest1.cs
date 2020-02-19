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
            Operations calculator = new Operations();
            float i1 = 2;
            float i2 = 3;

            float result = calculator.Add(i1, i2);

            Assert.AreEqual(i1 + i2, result);
        }
    }
}
