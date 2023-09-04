using CafeAutomation.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Validations
{
    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(x => x.MenuName).NotEmpty().WithMessage("Menu adı boş olamaz"); 
        }
    }
}
