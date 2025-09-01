using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class HouseModel
    {
        public int HouseId { get; set; }
        public int HouseIP4 { get; set; }
        public int HouseOwner_Id { get; set; }
        public bool IsHouseActive { get; set; }


        public string HouseName { get; set; }
        public string HousePassword { get; set; }
    }

}

