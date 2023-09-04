using CafeAutomation.Entities.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAutomation.Entities.Tools
{
    public class ValidatorTools
    {
        public static bool Validates(IValidator validator,IEntity entity)
        {
            bool result = true;
            ValidationContext<IEntity> context = new ValidationContext<IEntity>(entity);
            var validationResult=validator.Validate(context);
            if (!validationResult.IsValid)
            {
                string msg = "";
                foreach (var item in validationResult.Errors)
                {
                    msg += item.ErrorMessage+"\n";
                }
                MessageBox.Show(msg);
                result = false;
            }
            return result;
        }
    }
}
