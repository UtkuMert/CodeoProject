using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDemo2.DAL;

namespace UserDemo2.ViewModel
{
    public class MainWindowViewModel
    {
        public ObservableCollection<User> Users { get; private set; }

        public MainWindowViewModel() 
        {
            Users = UserDal.GetAll();
        }


    }
}
