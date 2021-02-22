using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.ReturnDate).NotEmpty();
            RuleFor(r => r.ReturnDate).Null().WithMessage("Bu arabamız şuan başka birine kiralanmıştır. Lütfen başka bir araba seçiniz.");
        }

       
    }
}
