using Microsoft.VisualStudio.TestTools.UnitTesting;
using Axvigs.Aaron.PotD.X201403;
using System;

namespace Axvigs.Aaron.Test.PotD.X201403
{
    [TestClass]
    public class X20140312Tests
    {
        [TestMethod]
        public void ClockHandAngleTest()
        {
            Time six = new Time() { Hour = 6, Minute = 0 };
            Assert.AreEqual(90, X20140312.GetAngle(six));

            Time sixSeventeen = new Time() { Hour = 6, Minute = 17 };
            Assert.AreEqual(7.75, X20140312.GetAngle(sixSeventeen));

            Time eighteenSeventeen = new Time { Hour = 18, Minute = 17 };
            Assert.AreEqual(172.25, X20140312.GetAngle(eighteenSeventeen));
        }
    }
}