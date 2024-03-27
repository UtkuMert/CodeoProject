using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserDemo2.Business;
using UserDemo2.DAL;

namespace UserDemo2.ViewModel.UserControls
{
    /// <summary>
    /// Interaction logic for LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
            LoginViewModel loginViewModel = new LoginViewModel();
            this.DataContext = loginViewModel;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
           
            if (LoginUserValidation.LoginValidation(tbxLoginName.Text, tbxLoginPassword.Text))
            {
                string name = tbxLoginName.Text;
              
                LoginBox.Visibility = Visibility.Hidden;
                btnLogin.Visibility = Visibility.Hidden;

                tbWelcome.Visibility = Visibility.Visible;
                btnLogout.Visibility = Visibility.Visible;

                tbWelcome.Text = "Welcome " + name;
               
            }
            else
            {
                MessageBox.Show("Name or password wrong!");
            }
         
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Name = "";
            LoginBox.Visibility = Visibility.Visible;
            btnLogin.Visibility = Visibility.Visible;

            tbWelcome.Visibility = Visibility.Hidden;
            btnLogout.Visibility = Visibility.Hidden;

            tbxLoginName.Text = "";
            tbxLoginPassword.Text = "";
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
    }
}
