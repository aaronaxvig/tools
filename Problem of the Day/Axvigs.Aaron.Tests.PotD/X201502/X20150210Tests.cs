using Axvigs.Aaron.PotD.X201502;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Axvigs.Aaron.Test.PotD.X201502
{
    [TestClass]
    public class X20150210Tests
    {
        [TestMethod]
        public void LuckyNumbersTest()
        {
            Assert.AreEqual(911, X20150210.GetLuckyNumberCount(0, 1000000));
        }
    }
}