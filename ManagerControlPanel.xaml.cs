using StorageForLease.Models;
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
    /// Interaction logic for ManagerControlPanel.xaml
    /// </summary>
    public partial class ManagerControlPanel : Window
    {
        private DbMethods methods = new DbMethods();

        public ManagerControlPanel()
        {
            InitializeComponent();
        }

        private void Show_All_customer(object sender, RoutedEventArgs e)
        {
            List<Customer> result;
            if ((result = methods.findAllCustomers()) != null)
                UserManagementWindow.ItemsSource = result;
            else
                MessageBox.Show($"There are no customers in database");
        }

        private void Delete_Order(object sender, RoutedEventArgs e)
        {
            int deleteItem = ((Storages)OrderManagementWindow.CurrentCell.Item).Product_Id;
            bool isSuccess = methods.deleteRecord("Manager",deleteItem);
            if (isSuccess)
            {
                MessageBox.Show($"Order number {deleteItem} has been successfuly deleted");

            }
            else
            {
                MessageBox.Show($"Order number {deleteItem} does not exist");

            }
        }

        private void Update_Order(object sender, RoutedEventArgs e)
        {
            bool isSucess;
            var record = OrderManagementWindow.CurrentCell.Item;
            isSucess = methods.updateOrder((Storages)record);
            if (isSucess)
                MessageBox.Show($"Order has been updated");
            else
                MessageBox.Show($"Failed to update order");

        }

        private void Delete_User(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deleting Customer will delete all his orders as well," +
                " Press Yes if you still wish to Delete Customer",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                bool isSuccess = false;
                Customer user = (Customer)UserManagementWindow.CurrentCell.Item;
                isSuccess = methods.deleteCustomer(user);
                if (isSuccess)
                    MessageBox.Show($"Customer has been deleted from database");
                else
                    MessageBox.Show($"Failed to delete customer from database");
            }
            else
                MessageBox.Show($"Customer was not deleted");
        }
        private void Update_User(object sender, RoutedEventArgs e)
        {
            bool isSuccess;
            var user = UserManagementWindow.CurrentCell.Item;
            isSuccess = methods.updateUser((Customer)user);
            if (isSuccess)
                MessageBox.Show($"Customer has been updated");
            else
                MessageBox.Show($"Failed to update Customer");
        }

        private void Search_Customer_By_ID(object sender, RoutedEventArgs e)
        {
            int customerId;
            bool isSuccess = int.TryParse(SearchByCustomerId.Text, out customerId);
            if (isSuccess)
            {
                Customer temp = methods.findCustomer(customerId);
                if (ValidationMethods.IsLegalPassword(customerId.ToString()) || temp != null)
                {
                    UserManagementWindow.ItemsSource = new List<Customer>() { temp };
                }
                else
                    MessageBox.Show($"Customer does not exist");
            }
            else
            {
                MessageBox.Show($"Oops! something went wrong the customer id is not valid");
            }
        }

        private void Show_All_Orders(object sender, RoutedEventArgs e)
        {
            List<Storages> result = methods.findallOrder();
            if (result != null)
                OrderManagementWindow.ItemsSource = result;
            else
                MessageBox.Show($"There are no orders in the database");
        }

        private void Search_Order_By_ProductID(object sender, RoutedEventArgs e)
        {
            int orderId;
            if (!int.TryParse(SearchOrderByProductId.Text, out orderId))
            {
                MessageBox.Show("You have enter invalid ID, Please enter valid ID number");
            }
            else
            {
                Storages temp = methods.findOrder("Manager",orderId);
                if (temp != null)
                {
                    List<Storages> result = new List<Storages>() { temp };
                    OrderManagementWindow.ItemsSource = result;
                }
                else
                    MessageBox.Show($"Order number {orderId} does not exist");
            }
        }

        private void Search_Order_By_UserId(object sender, RoutedEventArgs e)
        {
            string userID = SearchOrderByUserId.Text;
            if (!ValidationMethods.IsLegalId(userID))
            {
                MessageBox.Show($"{userID} is not a valid id please insert a legal customer ID");
            }
            else if (!methods.CheckIfCustomerExist(userID,"Customer"))
            {
                MessageBox.Show($"Customer does not exist in database");

            }
            else
            {
                List<Storages> orders = methods.findOrderByUserId(userID);
                if (orders.Count == 0)
                {
                    MessageBox.Show($"User does not have orders");
                }
                else
                {
                    OrderManagementWindow.ItemsSource = orders;
                }
            }
        }

        private void ShowSummary_Click(object sender, RoutedEventArgs e)
        {
            //general_info
            int ProductCount =  methods.getOrdersQuantity();
            int CustomerCount = methods.usersQuantity();

            List<GeneralData> data = new List<GeneralData>();
            data.Add(new GeneralData(CustomerCount, ProductCount));
            general_info.ItemsSource =data;

        }
    }
}
