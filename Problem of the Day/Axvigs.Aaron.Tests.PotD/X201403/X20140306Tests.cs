using Microsoft.VisualStudio.TestTools.UnitTesting;
using Axvigs.Aaron.PotD.X201403;
using System;

[assembly: CLSCompliant(true)]
namespace Axvigs.Aaron.Test.PotD.X201403
{
    [TestClass]
    public class X20140306Tests
    {
        [TestMethod]
        public void DecryptionTest()
        {
            X20140306 decrypter = new X20140306("REDDIT");
            Assert.AreEqual("TODAYISMYBIRTHDAY", decrypter.Decrypt("KSGDGBJQBEQKKLGDG"));
        }

        [TestMethod]
        public void EncryptionTest()
        {
            X20140306 encrypter = new X20140306("REDDIT");
            Assert.AreEqual("KSGDGBJQBEQKKLGDG", encrypter.Encrypt("TODAYISMYBIRTHDAY"));
        }
    }
}
