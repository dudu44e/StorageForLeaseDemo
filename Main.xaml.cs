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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }
        private void ManagerLogin_Click(object sender, RoutedEventArgs e)
        {
            new ManagerLoginPage().Show();
            this.Close();
        }

        private void ManagerSignup_Click(object sender, RoutedEventArgs e)
        {
            new ManagerSignUpPagexaml().Show();
            this.Close();
        }

        private void CustomerLogin_Click(object sender, RoutedEventArgs e)
        {
            new CustomerLoginPage().Show();
            this.Close();
        }

        private void CustomerSignup_Click(object sender, RoutedEventArgs e)
        {
            new CustomerSighUp().Show();
            this.Close();
        }
    }

}
