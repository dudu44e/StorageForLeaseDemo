using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageLease.model
{
    
    interface Users
    {
        public string User_Id { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }


    }
}
