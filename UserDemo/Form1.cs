using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDemo.DAL;

namespace UserDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public UserDal _userDal = new UserDal();


        public void LoadProducts()
        {
            dgwUser.DataSource = _userDal.GetAll();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _userDal.Add(new User
            {
                Name = tbxUsername.Text,
                Password = tbxPassword.Text,
            });

            MessageBox.Show("User Added!");
            LoadProducts();

            tbxUsername.Text = "";
            tbxPassword.Text = "";
        }
    }
}
