using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.houseService
{
    public interface IHouseService
    {
        List<HouseModel> GetAllHouses();
    }
}
