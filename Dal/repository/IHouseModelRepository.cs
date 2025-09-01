using Dal.context;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.repository
{
    public interface IHouseModelRepository
    {




        public  Task<HouseModel> GetAllHousesAsync();
        
    }
}
