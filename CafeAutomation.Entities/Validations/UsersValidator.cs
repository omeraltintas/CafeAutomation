using CafeAutomation.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Validations
{
    public class UsersValidator : AbstractValidator<Users>
    {
        public UsersValidator()
        {
            RuleFor(x=>x.NameSurname).NotEmpty().WithMessage("Ad soyad boş olamaz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(x => x.UserName).MinimumLength(2).WithMessage("2den az olamaz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("yanlış mail formatı");
        }
    }
}
