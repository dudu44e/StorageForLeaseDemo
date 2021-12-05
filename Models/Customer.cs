using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageLease.model
{
    public class Customer : Users
    {
        [Key,Required]
        public string User_Id { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public Customer()
        {

        }
        public Customer(string id, string username, string password,string email)
        {
            this.User_Id = id;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.IsActive = true;
        }
    }
}

