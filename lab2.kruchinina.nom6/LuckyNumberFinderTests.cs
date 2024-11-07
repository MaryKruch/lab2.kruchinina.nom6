
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace lab2.kruchinina.nom6
{
    public class LuckyNumberFinderTests
    {
        [TestMethod]
        public void TestSumOfDigits()
        {
            LuckyNumberFinder finder = new LuckyNumberFinder();
            Assert.AreEqual(6, finder.SumOfDigits(123)); // 1 + 2 + 3 = 6
            Assert.AreEqual(15, finder.SumOfDigits(789)); // 7 + 8 + 9 = 24
            Assert.AreEqual(0, finder.SumOfDigits(0)); // 0
        }

        [TestMethod]
        public void TestIsLuckyNumber()
        {
            LuckyNumberFinder finder = new LuckyNumberFinder();
            Assert.IsTrue(finder.IsLuckyNumber(123321)); // 1+2+3 == 3+2+1
            Assert.IsFalse(finder.IsLuckyNumber(123456)); // 1+2+3 != 4+5+6
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIsLuckyNumber_OutOfRange()
        {
            LuckyNumberFinder finder = new LuckyNumberFinder();
            finder.IsLuckyNumber(12345); // Не шестизначный номер
        }
    }
}