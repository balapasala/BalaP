﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersTechTest;

namespace UnitTestProject
{
    [TestClass]
    public class PrintNumbersTest
    {
        [TestMethod]
        public void DisplayNumbersvalidation()
        {
            bool blnexpected = true;
            PrintNumbers obj = new PrintNumbers();
            bool blnStatus= obj.DisplayNumber(100);

            //Assert  
            Assert.AreEqual(blnexpected, blnStatus);
        }
    }
}