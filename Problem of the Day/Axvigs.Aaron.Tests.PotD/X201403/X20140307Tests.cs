using Microsoft.VisualStudio.TestTools.UnitTesting;
using Axvigs.Aaron.PotD.X201403;
using System;

namespace Axvigs.Aaron.Test.PotD.X201403
{
    [TestClass]
    public class X20140307Tests
    {
        [TestMethod]
        public void ResponseTest()
        {
            int[][] challenge = {   new int[] { 1, 2, 3, 4, 5 },
                                    new int[] { 6, 7, 8, 9, 10 },
                                    new int[] { 11, 12, 13, 14, 15 },
                                    new int[] { 16, 17, 18, 19, 20 },
                                    new int[] { 21, 22, 23, 24, 25 } };

            int[][] expectedResponse = {    new int[] { 21, 16, 11, 6, 1 },
                                            new int[] { 22, 17, 12, 7, 2 },
                                            new int[] { 23, 18, 13, 8, 3 },
                                            new int[] { 24, 19, 14, 9, 4 },
                                            new int[] { 25, 20, 15, 10, 5 } };

            int[][] response = X20140307.GenerateResponse(challenge);

            for (int i = 0; i < challenge.GetLength(0); i++)
            {
                CollectionAssert.AreEqual(expectedResponse[i], response[i]);
            }
        }
    }
}