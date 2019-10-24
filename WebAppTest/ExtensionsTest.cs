using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions;

namespace WebAppTest
{
    [TestClass]
    public class ExtensionsTest
    {
        [TestMethod]
        public void LimitsTest()
        {
            double test = Functions.limits(30, 0, 100, 0, -200);
            Assert.AreEqual(-60, test);

            test = Functions.limits(30, 0, 100, 0, 200);
            Assert.AreEqual(60, test);
        }

        [TestMethod]
        public void LimitsTest_fall()
        {
            double test = Functions.limits(30, 0, 100, 0, -200);
            Assert.AreEqual(-50, test);

            test = Functions.limits(30, 0, 100, 0, 200);
            Assert.AreEqual(60, test);
        }
    }
}
