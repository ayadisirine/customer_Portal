using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers_Portal.Models
{
    public class BuildingModel
    {
        public long id { get; set; }
        public string addressBuilding { get; set; }
        public string fullNameAdministrator { get; set; }
        public string emailAdministrator { get; set; }
        public string phoneAdministrator { get; set; }
        public string fullNameTechnicalContactBuilding { get; set; }
        public string technicalContactBuildingEmail { get; set; }
        public string technicalContactBuildingPhone { get; set; }
        public long? customerId { get; set; }


    }
}
