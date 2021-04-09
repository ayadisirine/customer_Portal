using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers_Portal.Models
{
    public class BatteryModel
    {
       public long id { get; set; }
        public long? buildingId { get; set; }
        public string status { get; set; }
        public DateTime? dateCommissioning { get; set; }
        public DateTime? dateLastInspection { get; set; }
        public string certificateOfOperations { get; set; }
        public string information { get; set; }
        public string notes { get; set; }
        public string batteryType { get; set; }
    }
}
