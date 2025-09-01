using Dal.repository;
using Domain;

namespace Bll.houseService
{
    public class HouseService : IHouseService
    {
       
        private readonly IHouseModelRepository _repository;

        public object MapToDto { get; private set; }

        public HouseService(IHouseModelRepository repository)
        {
            _repository = repository;
        }

        public List<HouseModel> GetAllHouses()
        {

            return null;
        }

        public async Task<IEnumerable<HouseModel>> GetAllHouseModelsAsync()
        {
            try
            {
                var products = await  _repository.GetAllHousesAsync();
               // return products.Select(MapToDto);
               return null;
            }
            catch (Exception ex)
            {
               // _logger.LogError(ex, "Error occurred while fetching all products");
                throw;
            }
        }
    }
}
