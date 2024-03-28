using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDemo2.DAL;

namespace UserDemo2.ViewModel
{
    public class UserWindowViewModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public UserProfile UserProfile { get; set; }

        public bool IsVisible { get; set; }

        public UserWindowViewModel(User user)
        {
            Name = user.Name;
            Password = user.Password;
            UserProfile = user.UserProfile;
            IsVisible = true;
        }
    }
}
