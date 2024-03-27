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
           
            if ((string)value == "")
            {
                return new ValidationResult(false, "Password cannot be null.");
            }

            if (value?.ToString().Length is < 4 or > 25)
            {
                return new ValidationResult(false, "Password should be between range 4-25");
            }

            return ValidationResult.ValidResult;
        }
    }
}
