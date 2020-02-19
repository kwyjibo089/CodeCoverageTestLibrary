using CodeCoverageTestLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_Add()
        {
            Operations calculator = new Operations();
            float i1 = 2;
            float i2 = 3;

            float result = calculator.Add(i1, i2);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test_Divide()
        {
            Operations calculator = new Operations();
            float i1 = 6;
            float i2 = 3;

            float result = calculator.Divide(i1, i2);

            Assert.AreEqual(2, result);
        }
    }
}
