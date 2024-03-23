using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDemo2.DAL;

namespace UserDemo2.ViewModel
{
    public class EditUserViewModel
    {
        public int Id { get; set; }
        public string EditName { get; set; }
        public string EditPassword { get; set; }

        public EditUserViewModel(User user)
        {
            this.Id = user.Id;
            this.EditName = user.Name;
            this.EditPassword = user.Password;
        }

 
    }
}
