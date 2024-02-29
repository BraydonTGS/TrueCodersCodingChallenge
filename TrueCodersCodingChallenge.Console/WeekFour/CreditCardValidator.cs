using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueCodersCodingChallenge.Console.WeekFour
{
    public class CreditCardValidator : AbstractValidator<string>
    {
        public CreditCardValidator()
        {
            RuleFor(x => x).NotNull().NotEmpty().CreditCard();
        }
    }
}
