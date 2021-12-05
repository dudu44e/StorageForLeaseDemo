using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageForLease.Models
{
    class GeneralData
    {
        public int CustomerCount { get; set; }
        public int OrdersCount { get; set; }

        public GeneralData()
        {
            this.CustomerCount = 0;
            this.OrdersCount = 0;
        }
        public GeneralData(int userCount, int ordersCount)
        {
            this.CustomerCount = userCount;
            this.OrdersCount = ordersCount;
        }
    }


}
