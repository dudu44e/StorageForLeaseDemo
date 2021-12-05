using StorageLease.Cruds;
using StorageLease.model;
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
    
    public partial class CustomerSighUp : Window
    {
        private DbMethods methods = new DbMethods();

        public CustomerSighUp()
        {
            InitializeComponent();
        }
       
        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            string id = ID.Text;
            string userName = Username.Text;
            string password = Password.Text;
            string email = Email.Text;

            if(id==null || userName==null || password==null || email==null)
            {
                MessageBox.Show("All fields must be filled, please try again");
            }
            else if(!ValidationMethods.IsLegalId(id))
            {
                MessageBox.Show($"{id} is not legal ID, please enter your ID");
            }
            else if (!ValidationMethods.IsLegalPassword(password))
            {
                MessageBox.Show($"{password} is not legal, password must have: " +
                    $"• At least one english letter " +
                    $"• At least one digit " + 
                    $"• character Minimum 8 in length");
                 
            }
            else if(!ValidationMethods.IsLegalEmail(email))
            {
                MessageBox.Show("Email address is not valid, please try again");
            }
            else
            {
                if (methods.idExist(id, "Customer")) { MessageBox.Show("ID already exist"); }
                if (methods.usernameExist(userName ,"Customer")) { MessageBox.Show("Username already taken, choose another Username"); }
                if (methods.EmailExist(userName ,"Customer")) { MessageBox.Show("Email already exist"); }
                else
                {
                    bool addUser = methods.addCustomer(new Customer(id, userName, password, email));
                    if (addUser)
                    {
                        MessageBox.Show($"Welcome {userName} your officaly a customer, now all is left is for you to enjoy our products");
                        
                        new CustomerLoginPage().Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("OOPS! something went wrong please contact customer serivce");
                }

            }
        }

        private void BackToMainPage_Click(object sender, RoutedEventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
