using TrueCodersCodingChallenge.Console.WeekFour;

namespace TrueCodersCodingChallenge.Tests.WeekFour
{
    [TestClass]
    public class ValidateCreditCardNumber_WeekFour_Tests
    {
        private readonly CreditCardValidator _validator;
        private readonly ValidateCreditCardNumber_WeekFour _creditCardNumberValidator;
        public ValidateCreditCardNumber_WeekFour_Tests()
        {
            _validator = new CreditCardValidator();
            _creditCardNumberValidator = new ValidateCreditCardNumber_WeekFour(_validator);
        }

        [TestMethod]
        [DataRow("5500000000000004")]
        [DataRow("340000000000009")]
        [DataRow("6011000000000004")]
        [DataRow("3530111333300000")]
        [DataRow("6759649826438453")]
        [DataRow("5019555544445555")]
        [DataRow("6304000000000000")]
        [DataRow("2223000048410010")]
        public void ValidateCreditCardNumber_CreditCardNumberIsValid_Success(string creditCardNumber)
        {

            var success = _creditCardNumberValidator.ValidateCreditCardNumber(creditCardNumber);
            Assert.IsTrue(success);
        }
    }
}
