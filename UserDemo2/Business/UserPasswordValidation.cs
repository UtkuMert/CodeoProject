using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UserDemo2.Business
{
    public class UserPasswordValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            //string? password = value as string;
            if ((string)value == "")
            {
                return new ValidationResult(false, "Password cannot be null.");
            }

            if(value?.ToString().Length < 3)
            {
                return new ValidationResult(false, "More than 2.");
            }

            //if (password?.Length < 3 || password?.Length > 25)
            //{
            //    return new ValidationResult(false, "Password should be between range 3-25");
            //}

            return ValidationResult.ValidResult;
        }
    }
}
