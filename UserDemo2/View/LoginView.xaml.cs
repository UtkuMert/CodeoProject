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
using UserDemo2.Business;
using UserDemo2.DAL;
using UserDemo2.ViewModel;

namespace UserDemo2.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            LoginViewModel loginViewModel = new LoginViewModel();
            this.DataContext = loginViewModel;
        }

        private void tbxLoginPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (tbxLoginName.Text == "" || tbxLoginPassword.Text == "")
            {
                btnLogin.IsEnabled = false;
            }
            else
            {
                btnLogin.IsEnabled = true;
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if (LoginUserValidation.LoginValidation(tbxLoginName.Text, tbxLoginPassword.Text))
            {
                string name = tbxLoginName.Text;

                    User user = UserDal.GetUserByName(name);
                    UserProfile profile = UserProfileDal.GetUserProfileById(user.UserProfileId);
                    user.UserProfile = profile;

                    if (user.UserProfile.IsAdmin)
                    {
                        MainWindow mainWindow = new MainWindow(user);
                        mainWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Welcome User");
                    }
                

            }
            else
            {
                MessageBox.Show("Name or password wrong!");
            }

        }
    }
}
