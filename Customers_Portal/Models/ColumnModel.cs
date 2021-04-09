using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers_Portal.Models
{
    public class ColumnModel
    {
        public long Id { get; set; }
        public long? BatteryId { get; set; }
        public int? NumberOfFloorsServed { get; set; }
        public string Status { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public string ColumnType { get; set; }


    }
}
