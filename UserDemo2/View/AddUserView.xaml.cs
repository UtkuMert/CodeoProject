using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AddUserView.xaml
    /// </summary>
    public partial class AddUserView : Window
    {
        public ObservableCollection<UserProfile> userProfiles;
        public AddUserView()
        {
            InitializeComponent();
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            this.DataContext = addUserViewModel;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            
            UserProfile profil = UserProfileDal.GetUserProfileByName(cbxRole.Text);
            
            User user = new User
            {
               Name = tbxName.Text,
               Password = tbxPassword.Text,
               UserProfileId = profil.Id,
            };


            if (Validation.GetHasError(tbxPassword) || Validation.GetHasError(tbxName))
            {
                MessageBox.Show("Error");
            }
            else
            {
                UserDal.Add(user);
                MessageBox.Show("User added!");


                this.Close();
            }
        }


        private void tbxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox? tb = sender as TextBox;
            if (tbxName.Text != "" && tbxPassword.Text != "" && Validation.GetHasError(tbxName) == false && Validation.GetHasError(tbxPassword) == false)
            {
                btnAdd.IsEnabled = true;
            }
            else
            {
                btnAdd.IsEnabled = false;
            }
        }

        private void cbxRole_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
