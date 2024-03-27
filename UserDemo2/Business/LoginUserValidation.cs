using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;
using UserDemo2.DAL;

namespace UserDemo2.Business
{
    public static class LoginUserValidation 
    {

        public static bool LoginValidation(string name, string password)
        {
            using (UserDbContext db = new UserDbContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Name == name);

                if (user != null)
                {
                    if (user.Password == password)
                    {
                        return true;
                    }
                    else
                    {
                       return false;
                    }
                }
                else
                {
                    return false;

                }
            }
        }
      
    }
}

