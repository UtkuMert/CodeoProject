using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using UserDemo2.Business;
using UserDemo2.DAL;
using UserDemo2.View;
using UserDemo2.ViewModel;

namespace UserDemo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public ObservableCollection<User> users;
       
        public User? selected_row;

        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            this.DataContext = mainWindowViewModel;
            dataGrid.ItemsSource = mainWindowViewModel.Users;
            //LoadData();
          
        }
        private void LoadData()
        {
            users = UserDal.GetAll();
            dataGrid.ItemsSource = users;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            selected_row = (User)dg.SelectedItem;
            if ( selected_row != null )
            {
                btnDelete.IsEnabled = true;
                btnEdit.IsEnabled = true;
            }
            else
            {
                btnDelete.IsEnabled = false;
                btnEdit.IsEnabled = false;
            }
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            UserDal.Delete(new User
            {
                Id = Convert.ToInt32(selected_row.Id.ToString()),
            });
            MessageBox.Show("Deleted");
           LoadData();
            
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
        
            EditUserView editUserView = new EditUserView(selected_row);

            editUserView.ShowDialog();

            LoadData();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddUserView addUserView = new AddUserView();

            addUserView.ShowDialog();

            LoadData();
        }

    }
}