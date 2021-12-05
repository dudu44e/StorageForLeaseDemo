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

    public partial class ManagerLoginPage : Window
    {
        private DbMethods methods = new DbMethods();

        public ManagerLoginPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string userName = Username.Text;
            string password = Password.Password;
            int managerPassword;
            bool a = int.TryParse(ACode.Text,out managerPassword);

            if (!methods.checkIfManagerExist(userName, password, managerPassword) || !a || userName==null || password ==null)
            {
                MessageBox.Show($"Username, Password or Authorization code are incorrect");
            }
            else
            {
                new ManagerControlPanel().Show();
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
