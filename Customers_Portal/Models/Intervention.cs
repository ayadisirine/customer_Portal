using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers_Portal.Models
{
    public class Intervention
    {

        public long Id { get; set; }
        public int? BatteryId { get; set; }
        public int? ColumnId { get; set; }
        public int? ElevatorId { get; set; }
        public int? EmployeeId { get; set; }
        public string Result { get; set; }
        public string Report { get; set; }
        public string Status { get; set; }
        public long? EmployeesId { get; set; }
        public long? CustomersId { get; set; }
        public long? BuildingsId { get; set; }


    }
}
