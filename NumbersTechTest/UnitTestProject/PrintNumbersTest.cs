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
            bool blnexpected = true;
            PrintNumbers obj = new PrintNumbers();
            bool blnStatus= obj.DisplayNumber(150);

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
