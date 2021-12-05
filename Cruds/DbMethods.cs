using StorageLease.DataAccess;
using StorageLease.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StorageLease.Cruds
{
    public class DbMethods
    {
        /* enum to hold prices for each storage size (dollars per day)*/ 
        public enum sizePrices { ExtraSmall = 5, Small = 10, Medium = 15, Large = 20, ExtraLarge = 30, Huge = 40, Gaigantic = 60 }

        //-------------------------------------customers methods---------------------------//
        /*this function retries a list of all customers, return null if database is empty*/
        public List<Customer> findAllCustomers()
        {
            using (var context = new StorageDbContext())
            {
                List<Customer> allCustomers = null;
                try { allCustomers = context.Customers.ToList(); }
                catch {  }
                return allCustomers;
                
            }
        }

        /*this function retrieves a customer by id from database*/
        public Customer findCustomer(int id)
        {
            using (var context = new StorageDbContext())
            {

                var customer = context.Customers.Find(id.ToString());
                return customer;
            }
        }

        /* this function checks if manager exist in database return true if success or false if fail*/ 
        internal bool checkIfManagerExist(string userName, string password, int aCode)
        {
            using (var context = new StorageDbContext())
            {
                return context.Managers.Where(a=>String.Equals(a.Username,userName)).Any(manager => manager.Password.Equals(password) && manager.Manager_Password==aCode);

            }
        }

        /* this function returns the ID of a user with a given 2 strings: username and password*/
        internal String getId(string userName, string password)
        {
            using (var context = new StorageDbContext())
            {

                String s = (from a in context.Customers
                            where a.Username.Equals(userName) && a.Password.Equals(password)
                            select a.User_Id).Single();

               return s;     
            }

        }

        /* this function checks if user exist in databse returns true if success or false if fail*/
        internal bool checkIfUserExist(string userName, string password)
        {
            using (var context = new StorageDbContext())
            {
                
                return context.Customers.Where(a => String.Equals(a.Username, userName)).Any(a => String.Equals(a.Password, password));
            }
        }

        /* this function delete customer + all his orders from database returns true if success or false if failed */
        public bool deleteCustomer(Customer record)
        {
            bool isSuccess = false;

            using (var context = new StorageDbContext())
            {
                try
                {
                    context.Storages.RemoveRange(context.Storages.Where(c => c.User_Id == record.User_Id));
                    context.Customers.Remove(record);
                    context.SaveChanges();
                     isSuccess=true;
                }
                catch
                { }
                return isSuccess;
            }
        }

        /* this function add's a customer to database and returns true if success or false if failed*/
        public bool addCustomer(Customer customer)
        {
            bool isSuccess = false; ;
            using (var context = new StorageDbContext())
            {
                context.Customers.Add(customer);

                var a = context.SaveChanges();
                if (a == 1)
                {
                    isSuccess = true;
                }
            }
            return isSuccess;
        }

        /* this function update a customer details return true if success or false if fail*/
        internal bool updateUser(Customer user)
        {
            bool isSuccess = false;
            try
            {
                using (var context = new StorageDbContext())
                {
                    context.Customers.Update(user);
                    if (context.SaveChanges() == 1)
                        isSuccess = true;
                }
            }
            catch { }
            return isSuccess;
        }

        /* this function add's a new manager to database returns true if success or false if fail*/
        public bool addManager(Manager customer)
        {
            bool isSuccess = false; ;
            using (var context = new StorageDbContext())
            {
                var b =context.Managers.Add(customer);

                var a = context.SaveChanges();
                if (a == 1)
                {
                    isSuccess = true;
                }
            }
            return isSuccess;
        }


        //-------------------------------------products methods---------------------------//

        /* this function retrieves an order by user id and product id from data base, 
         * if the user id is classified  as manage then ignores the demand for user id.
         if a user request the order then search the order by user id and product id*/

        public Storages findOrder (string userId,int orderId)
        {
            using (var context = new StorageDbContext()) {
                if(String.Equals(userId,"Manager"))
                {
                    return context.Storages.Where(a =>a.Product_Id == orderId).FirstOrDefault();
                }
                Storages order = context.Storages.Where(a=>a.User_Id.Equals(userId) && a.Product_Id==orderId).FirstOrDefault();
                return order;
            }
        }

        /* this function updates an order return true if success or false if failed  */
        public bool updateOrder(Storages record)
        {
            bool isSuccess = false;
            try
            {
                using (var context = new StorageDbContext())
                {
                    context.Storages.Update(record);
                    if (context.SaveChanges() == 1)
                        isSuccess = true;
                }
            }
            catch { }
            return isSuccess;
        }

        /* this function retrieves all orders that belong's to the user.*/
       public List<Storages> findOrderByUserId(string userId)
        {
            using (var context = new StorageDbContext())
            {
                List<Storages> order = context.Storages.Where(t => t.User_Id.Equals(userId)).ToList();
                return order;
            }
        }


        /* this function delete order from database*/
        public bool deleteRecord(string userId,int recordId)
        {
            bool isSuccess = false;
            try
            {
                using (var context = new StorageDbContext())
                {
                    context.Storages.Remove(findOrder(userId,recordId));
                    if (context.SaveChanges() == 1)
                        isSuccess = true;
                }
            }
            catch { }
            return isSuccess;
        }

        /* this function retrieves all orders in database*/
            public List<Storages> findallOrder()
        {
            using (var context = new StorageDbContext())
            {
                var allOrders = context.Storages.ToList();
                return allOrders;
            }
        }
        
       
        /* this function adds a new order to database*/
        public bool addOrder(Storages order)
        {
            bool isSuccess = false; ;
            using (var context = new StorageDbContext())
            {
                context.Add(order);
                var a =context.SaveChanges();
                if (a==1)
                {
                    isSuccess = true;
                }
            }
            return isSuccess;
        }

        /* this function creates and returns a new order*/
        public Storages createOrder(string id, string size, string location, int leastime, string comment)
        {
            int Price = leastime * enumVal(size);

            return new Storages(id,size, location, Price, leastime, comment);
        }

        //-------------------------------------general methods---------------------------//

        /*checks if customer exist return true if success or false if fail*/
        public bool CheckIfCustomerExist(string id, string table)
        {
            using (var context = new StorageDbContext())
            {
                /* if the function is activated through the user controll panel*/
                if (table.Equals("Customer")) 
                {
                    try { return context.Customers.Any(customer => customer.User_Id.Equals(id)); }
                    catch { return false; }
                }
                else/* if the function is activated through the manager controll panel*/
                {
                    try { return context.Managers.Any(Managers => Managers.User_Id.Equals(id)); }
                    catch { return false; }
                }
                
            }
        }

        /* checks if id exist in database*/
        public bool idExist(string id, string table)
        {
            using (var context = new StorageDbContext())
            {
                if (table.Equals("Customer")) /* if the function is activated through the user controll panel*/
                {
                    try { return context.Customers.Any(customer => customer.User_Id.Equals(id)); }
                    catch { return false; }
                }
                else/* if the function is activated through the manager controll panel*/
                {
                    try { return context.Managers.Any(manager => manager.User_Id.Equals(id)); }
                    catch { return false; }
                }

            }
        }

            /* checks if username exist in database retrun true if success or false if not exist*/
        public bool usernameExist(string username, string table)
        {
            using (var context = new StorageDbContext())
            {
                if (table.Equals("Customer"))
                {
                    try { return context.Customers.Any(customer => customer.Username.Equals(username)); }
                    catch { return false; }
                }
                else
                {
                    try { return context.Managers.Any(manager => manager.Username.Equals(username)); }
                    catch { return false; }
                }
               
            }
        }

        /*checks if email exist in database return false if success or false if not exist*/
        public bool EmailExist(string email, string table)
        {
            using (var context = new StorageDbContext())
            {
                if (table.Equals("Customer"))
                {
                    try
                    {
                        return context.Customers.Any(customer => customer.Email.Equals(email));
                    }
                    catch { return false; }
                }
                else
                {
                    try
                    {
                        return context.Managers.Any(manager => manager.Email.Equals(email));
                    }
                    catch { return false; }
                }
                
            }
        }

        /*returns the id of products once its added to database*/
        public int getOrderIdIndex()
        {
            int idIndex = 0;
            using (var context = new StorageDbContext())
            {
                idIndex = (from p in context.Storages
                           select p.Product_Id).Max();
            }
            return idIndex;
        }

        /* return the numeric value of storage sizes. those value represnt price per day in us dollars*/
        private int enumVal(string size)
        {
            int val = 0;
            foreach (var str in Enum.GetValues(typeof(sizePrices)))
            {
                if (str.ToString().Equals(size))
                    val = (int)str;
            }
            return val;
        }

        /* this function return how many orders in database*/
        internal int getOrdersQuantity()
        {
            using (var context = new StorageDbContext())
            {
                return context.Storages.Count();
            }
        }

        /* this function return how many customers in database*/
        internal int usersQuantity()
        {
            using (var context = new StorageDbContext())
            {
                return context.Customers.Count();
            }
        }
    }
    
}
