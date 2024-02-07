using TrueCodersCodingChallenge.Console.WeekOne;

namespace TrueCodersCodingChallenge.Tests.WeekOne
{
    [TestClass]
    public class DetermineFactorial_WeekOne_Tests
    {

        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        [DataRow(3, 6)]
        [DataRow(4, 24)]
        [DataRow(5, 120)]
        [DataRow(6, 720)]
        [DataRow(7, 5040)]
        [DataRow(8, 40320)]
        [DataRow(9, 362880)]
        [DataRow(10, 3628800)]
        public void CalculateTheFactorial_OfTheSpecifiedNumber_Success(int num, int expected)
        {
            var factorial = DetermineFactorial_WeekOne.DetermineFactorial(num);

            Assert.IsNotNull(factorial);
            Assert.AreEqual(expected, factorial);


        }

        [TestMethod]
        [DataRow(0, 1)]
        public void CalculateTheFactorial_OfTheSpecifiedNumber_NumberIsZero_ReturnsOne_Success(int num, int expected)
        {
            var factorial = DetermineFactorial_WeekOne.DetermineFactorial(num);

            Assert.IsNotNull(factorial);
            Assert.AreEqual(expected, factorial);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-2)]
        [DataRow(-3)]
        [DataRow(-4)]
        [DataRow(-5)]
        [DataRow(-6)]
        [DataRow(-7)]
        [DataRow(-8)]
        [DataRow(-9)]
        [DataRow(-10)]
        public void CalculateTheFactorial_OfTheSpecifiedNumber_NumberIsNegative_ThrowsArgumentException_Success(int num)
        {
            Assert.ThrowsException<ArgumentException>(() => DetermineFactorial_WeekOne.DetermineFactorial(num));
        }
    }
}
