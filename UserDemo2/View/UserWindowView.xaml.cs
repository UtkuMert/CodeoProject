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
    /// Interaction logic for UserWindowView.xaml
    /// </summary>
    public partial class UserWindowView : Window
    {
        public UserWindowView()
        {
            InitializeComponent();
        }

        public UserWindowView(User user)
        {
            InitializeComponent();
            UserWindowViewModel viewModel = new UserWindowViewModel(user);
            this.DataContext = viewModel;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = null;

            LoginView loginView = new LoginView();
            loginView.Show();

            this.Close();
        }
    }
}
