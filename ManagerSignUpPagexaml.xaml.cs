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
    /// <summary>
    /// Interaction logic for ManagerSignUpPagexaml.xaml
    /// </summary>
    public partial class ManagerSignUpPagexaml : Window
    {
        private DbMethods methods = new DbMethods();

        public ManagerSignUpPagexaml()
        {
            InitializeComponent();
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            string id = ID.Text;
            string userName = Username.Text;
            string password = Password.Text;
            string email = Email.Text;
            string aCode = AuthorizationCode.Text;

            if (id == null || userName == null || userName.Length==0 || password == null || email == null || aCode==null)
            {
                MessageBox.Show("All fields must be filled, please try again");
            }
            else if(!aCode.Equals("0"))
            { MessageBox.Show("Authorization code is wrong"); }
            else if (!ValidationMethods.IsLegalId(id))
            {
                MessageBox.Show($"{id} is not legal ID, please enter your ID");
            }
            else if (!ValidationMethods.IsLegalPassword(password))
            {
                MessageBox.Show($"{password} is not legal, password must have: " +
                    $"• At least one Upper case " +
                    $"• At least one digit " +
                    $"• character Minimum 8 in length");

            }
            else if (!ValidationMethods.IsLegalEmail(email))
            {
                MessageBox.Show("Email address is not valid, please try again");
            }
            else
            {
                if (methods.idExist(id,"manager")) { MessageBox.Show("ID already exist"); }
                else if (methods.usernameExist(userName, "manager")) { MessageBox.Show("Username already taken, choose another Username"); }
                else if (methods.EmailExist(userName, "manager")) { MessageBox.Show("Email already exist"); }
                else
                {
                    bool addUser = methods.addManager(new Manager(id, userName, password, email));
                    if (addUser)
                    {
                        MessageBox.Show($"Welcome {userName} your officaly a manager and have access to all the customers and orders database");

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
