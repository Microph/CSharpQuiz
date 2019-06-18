using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestGenKBTGMail
    {
        #region Main Testing Method
        private void MAIN_TestGenKBTGMail(string[] inputArray, string[] expectedOutputArray)
        {
            string[] testingMethodOutput = new Quiz().GenKBTGMail(inputArray);

            if (testingMethodOutput.Length != expectedOutputArray.Length)
            {
                Assert.Fail("Incorrect number of generated emails");
            }

            for (int i = 0; i < expectedOutputArray.Length; i++)
            {
                Assert.IsTrue(testingMethodOutput[i].Equals(expectedOutputArray[i]));
            }
        }
        #endregion

        //1
        [DataRow(null, new string[] { "Tycho Daviti"        , "Dianne Brit"         , "Max Maile" }
                     , new string[] { "tycho.d@kbtg.tech"   , "dianne.b@kbtg.tech"  , "max.m@kbtg.tech" })]
        [TestMethod]
        public void TestGenKBTGMail1(object notUsed, string[] inputArray, string[] expectedOutputArray)
        {
            MAIN_TestGenKBTGMail(inputArray, expectedOutputArray);
        }

        //2
        [DataRow(null, new string[] { "Tycho Daviti"        , "Tycho Brit"          , "Tycho Bro"           , "Tycho Bruh"          , "Tycho Bruh"              , "Tycho Bruh"          , "Tycho Bruh" }
                     , new string[] { "tycho.d@kbtg.tech"   , "tycho.b@kbtg.tech"   , "tycho.br@kbtg.tech"  , "tycho.bru@kbtg.tech" , "tycho.bruh@kbtg.tech"    , "tycho.bruh2@kbtg.tech", "tycho.bruh3@kbtg.tech" })]
        [TestMethod]
        public void TestGenKBTGMail2(object notUsed, string[] inputArray, string[] expectedOutputArray)
        {
            MAIN_TestGenKBTGMail(inputArray, expectedOutputArray);
        }
    }
}
