using FluentValidation;

namespace TrueCodersCodingChallenge.Console.WeekFour
{
    /// <summary>
    /// Validate a CreditCard Number using Luhn Algorithm
    /// </summary>
    public class ValidateCreditCardNumber_WeekFour
    {
        private readonly CreditCardValidator _validator;
        public ValidateCreditCardNumber_WeekFour(CreditCardValidator validator) => _validator = validator;  
        public bool ValidateCreditCardNumber(string creditCardNumber) => _validator.Validate(creditCardNumber).IsValid;

    }
}
