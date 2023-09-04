using CafeAutomation.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Validations
{
    public class CustomersValidator:AbstractValidator<Customers>
    {
        public CustomersValidator() 
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Ad boş olamaz");
        }
    }
}
