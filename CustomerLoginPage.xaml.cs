using StorageLease.Cruds;
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

namespace StorageForLease
{
    /// <summary>
    /// Interaction logic for CustomerLoginPage.xaml
    /// </summary>
    public partial class CustomerLoginPage : Window
    {
        private DbMethods methods = new DbMethods();

        public CustomerLoginPage()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string userName = Username.Text;
            string password = Password.Password;
            if (!methods.checkIfUserExist(userName, password))
            {
                MessageBox.Show($"Username or Password are incorrect");
            }
            else
            {
                MessageBox.Show("User and Password is confirmed");
               String id= methods.getId(userName, password);
                new MainWindow(id).Show();
                this.Close();
            }
        }

        private void Main_Menue(object sender, RoutedEventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
