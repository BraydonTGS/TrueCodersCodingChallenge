using FluentValidation;

namespace TrueCodersCodingChallenge.Console.WeekFour
{
    /// <summary>
    /// Validate a CreditCard Number using Luhn Algorithm
    /// </summary>
    public class ValidateCreditCardNumber_WeekFour
    {
        public CreditCardValidator _validator { get; set; }
        public ValidateCreditCardNumber_WeekFour(CreditCardValidator validator ) => _validator = validator;
        public bool ValidateCreditCardNumber(string creditCardNumber) => _validator.Validate(creditCardNumber).IsValid;

    }
}
