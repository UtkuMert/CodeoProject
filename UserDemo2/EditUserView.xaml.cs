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

namespace UserDemo2
{
    /// <summary>
    /// Interaction logic for EditUserView.xaml
    /// </summary>
    public partial class EditUserView : Window
    {

        private EditUserViewModel editUserViewModel;
        public EditUserView(User selectedItem)
        {

            InitializeComponent();
            editUserViewModel = new EditUserViewModel(selectedItem);
     
            this.DataContext = editUserViewModel;

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            UserDal.Update(new User
            {
                Id = editUserViewModel.Id,
                Name = tbxEditName.Text,
                Password = tbxEditPassword.Text,
            });

            MessageBox.Show("Updated");
           
            tbxEditName.Text = "";
            tbxEditPassword.Text = "";
            this.Close();
        }
    }
}
