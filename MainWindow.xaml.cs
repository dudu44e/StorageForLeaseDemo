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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StorageForLease
{
    public partial class MainWindow : Window
    {
        private DbMethods methods = new DbMethods();
        private string id;

        string[] storageSizes = new[] { "ExtraSmall", "Small", "Medium", "Large", "ExtraLarge", "Huge", "Gaigantic" };
        string[] locations = new[] { "Berlin", "Tel-aviv", "Tokyo", "Washington D.C", "Mosco", "Istanbul", "Aman" };

       
        public MainWindow()
        {
            InitializeComponent();
            StorageSize.ItemsSource = storageSizes;
            Location.ItemsSource = locations;
        }
        public MainWindow(string id)
        {
            InitializeComponent();
            StorageSize.ItemsSource = storageSizes;
            Location.ItemsSource = locations;
            this.id = id;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            int orderId;
            if (!int.TryParse(SearchBox.Text, out orderId))
            {
                MessageBox.Show("You have enter invalid ID, Please enter valid ID number");
            }
            else
            {
                Storages result= methods.findOrder(id,orderId);
                
                if ( result==null)
                    MessageBox.Show("Order does not exist");
                else
                {

                    OrderWindow.ItemsSource = new List<Storages>() { result };
                }
            }
        }

        private void ShowAllOrders_Click(object sender, RoutedEventArgs e)
        {
            List<Storages> result = methods.findOrderByUserId(id);
            OrderWindow.ItemsSource = result;
            if (result.Count == 0)
                MessageBox.Show("There are no open orders");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int rentalTime;
            bool daysRequested = int.TryParse(RentalTime.Text, out rentalTime);
            if (!daysRequested || rentalTime <= 0 || Location.Text == null || StorageSize.Text == null)
            {
                MessageBox.Show("One of your inputs is incorrect. " +
                    "Make sure you have entered a valid number for " +
                    "rental period and you have chosen all options in storage size and location");
            }
            else
            {
                Storages newOrder = new Storages();
                newOrder = methods.createOrder(id,StorageSize.Text, Location.Text, rentalTime, Comments.Text);
                bool isSuccess = methods.addOrder(newOrder);
                if (isSuccess)
                {
                    MessageBox.Show("This is your order number" + methods.getOrderIdIndex());
                }
                else
                {
                    MessageBox.Show("OOPS!! something went wrong please contact customer service");
                }
            }

        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            int deleteItem = ((Storages)OrderWindow.CurrentCell.Item).Product_Id;
            bool isSuccess = methods.deleteRecord(id,deleteItem);
            if (isSuccess)
            {
                MessageBox.Show($"Order number {deleteItem} has been successfuly deleted");
            }
            else
            {
                MessageBox.Show($"Order number {deleteItem} does not exist");

            }
        }
    }
}
