using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersTechTest;

namespace UnitTestProject
{
    [TestClass]
    public class PrintNumbersTest
    {
        [TestMethod]
        public void DisplayNumbersvalidation()
        {

            int startNumber = 1;
            int EndNumber = 100;
            bool blnexpected = true;
            PrintNumbers obj = new PrintNumbers();
            bool blnStatus= obj.DisplayNumber(startNumber, EndNumber);

            //Assert  
            Assert.AreEqual(blnexpected, blnStatus);
        }

        [TestMethod]
        public void  PrimeNumbersvalidation()
        {
            bool blnexpected = true;
            PrintNumbers obj = new PrintNumbers();
            bool blnStatus = obj.isPrimeNumberCheck(5);
            //Assert  
            Assert.AreEqual(blnexpected, blnStatus);
        }

        [TestMethod]
        public void CompositeNumberValidation()
        {

            bool blnexpected = true;
            PrintNumbers obj = new PrintNumbers();
            bool blnStatus = obj.isCompositeNumberCheck(9);
            //Assert  
            Assert.AreEqual(blnexpected, blnStatus);

        }
        [TestMethod]
        public void PrimeandCompositeNumberValidation()
        {

            bool blnexpected = true;
            PrintNumbers obj = new PrintNumbers();
            bool blnStatus = obj.isPrimeOrCompositeNumberCheck(12);
            //Assert  
            Assert.AreEqual(blnexpected, blnStatus);

        }

    }
}
