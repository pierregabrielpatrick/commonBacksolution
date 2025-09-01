using Dal.context;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.repository
{
    public class HouseRepository : IHouseModelRepository
    {

        private readonly CommonContext commonContext;

        public HouseRepository()
        {
        }

        public HouseRepository(CommonContext commonContext)
        {
            this.commonContext = commonContext;
        }

        public async Task<IEnumerable<HouseModel>> GetAllHousesAsync()
        {
            return await commonContext.houseModels
                .OrderBy(p => p.HouseName)
                .ToListAsync();
        }
    }
}
