using Microsoft.VisualStudio.TestTools.UnitTesting;
using Axvigs.Aaron.PotD.X201403;
using System;

namespace Axvigs.Aaron.Test.PotD.X201403
{
    [TestClass]
    public class X20140311Tests
    {
        [TestMethod]
        public void PalindromeTest()
        {
            Assert.IsTrue(X20140311.IsPalindrome(12344321));
            Assert.IsTrue(X20140311.IsPalindrome(1234321));
            Assert.IsTrue(X20140311.IsPalindrome(123040321));
            Assert.IsTrue(X20140311.IsPalindrome(121));
            Assert.IsTrue(X20140311.IsPalindrome(1));
            Assert.IsFalse(X20140311.IsPalindrome(12345321));
            Assert.IsFalse(X20140311.IsPalindrome(12340321));
            Assert.IsFalse(X20140311.IsPalindrome(12));
        }
    }
}