using CafeAutomation.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Validations
{
    public class TableActionsValidator : AbstractValidator<TableActions>
    {
        public TableActionsValidator()
        {
            RuleFor(x => x.Amount).GreaterThan(0).WithMessage("0 dan büyük olmalı");
        }
    }
}
