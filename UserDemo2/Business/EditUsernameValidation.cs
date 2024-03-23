using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UserDemo2.DAL;

namespace UserDemo2.Business
{
    public class EditUsernameValidation: ValidationRule
    {


        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if ((string)value == "")
            {
                return new ValidationResult(false, "Name cannot be null.");
            }


            using (UserDbContext db = new UserDbContext())
            {
                if (db.Users.ToList().Any(x => x.Name == (string)value))
                {
                    return new ValidationResult(false, "Name already exist.");
                }
            }
            return ValidationResult.ValidResult;
        }
    }
}
