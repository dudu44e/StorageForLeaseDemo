using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageLease.model
{
   public class Manager : Users
    {
        [Key, Required]
        public string User_Id { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]

        public string Username { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public int Manager_Password { get; set; }

        public Manager()
        {

        }
        public Manager(string id, string username,string password, string email)
        {
            this.Username = username;
            this.User_Id = id;
            this.Password = password;
            this.Email = email;
            this.Manager_Password = 0 ;
        }
    }
}
