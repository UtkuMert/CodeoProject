using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDemo2.ViewModel
{
    public class AddProfileViewModel
    {
        public string RoleName { get; set; }
        public bool IsAdmin { get; set; } 
        public bool CanProjectAdd { get; set; }
        public bool CanProjectDelete { get; set; }
        public bool CanHardwareAdd { get; set; }
        public bool CanHardwareDelete { get; set; }
        public bool CanHardwareEdit { get; set; }
        public bool CanCustomerAdd { get; set; }

     

       


    }
}
