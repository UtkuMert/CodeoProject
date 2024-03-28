using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserDemo2.DAL;
using UserDemo2.ViewModel;

namespace UserDemo2.View
{
    /// <summary>
    /// Interaction logic for AddProfileView.xaml
    /// </summary>
    public partial class AddProfileView : Window
    {
        public AddProfileView()
        {
            InitializeComponent();
            AddProfileViewModel viewModel = new AddProfileViewModel();

            this.DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            UserProfile profile = new UserProfile()
            {
                RoleName = tbxRoleName.Text,
                IsAdmin =(bool)IsAdmin.IsChecked,
                CanCustomerAdd = (bool)CanCustomerAdd.IsChecked,
                CanHardwareAdd = (bool)CanHardwareAdd.IsChecked,
                CanHardwareDelete = (bool)CanHardwareDelete.IsChecked,
                CanHardwareEdit = (bool)CanHardwareEdit.IsChecked,
                CanProjectAdd = (bool)CanProjectAdd.IsChecked,
                CanProjectDelete = (bool )CanProjectDelete.IsChecked,
            };

            UserProfileDal.Add(profile);

          this.Close();
        }
    }
}
