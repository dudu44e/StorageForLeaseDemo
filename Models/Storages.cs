using StorageLease.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageLease.model
{
    public class Storages
    {
        
        [Key, Required]
        public int Product_Id { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Location { get; set; }
        public int Price { get; set; }
        [Required]
        public int LeaseTime { get; set; }/*in days*/
        [ForeignKey("Customer")]
        public string User_Id { get; set; }
        public Customer Customer { get; set; }
        [NotMapped]
        public string comment { get; set; }

        public Storages()
        {

        }
        public Storages( string id,string size, string location, int price, int leasetime, string comment)
        {
            this.Size = size;
            this.Location = location;
            this.Price = price;
            this.LeaseTime = leasetime;
            this.comment = comment;
            this.User_Id = id;
        }
        public override string ToString()
        {
             return $"{Product_Id} {Size} {Location} {LeaseTime} {Price}"; 
        }


    }
}
