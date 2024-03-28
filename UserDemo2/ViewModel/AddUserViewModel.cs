using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDemo2.Business;
using UserDemo2.DAL;

namespace UserDemo2.ViewModel
{
    public class AddUserViewModel
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public ObservableCollection<UserProfile> UserProfiles { get; set; } = new ObservableCollection<UserProfile>(UserProfileDal.GetAll());


        public AddUserViewModel()
        {
            Name = RandomGenerator.GenerateRandomUserName();
            Password = RandomGenerator.GenerateRandomPassword();
        }
    }
}
