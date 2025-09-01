using Bll.houseService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace commonBacksolution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseIOTController : ControllerBase
    {
        private readonly IHouseService service;

        public HouseIOTController(IHouseService service)
        {
            this.service = service;
        }

        [HttpGet]           
        public IActionResult GetHouses() {
        
            var houses = service.GetAllHouses();

            return Ok(houses);
        }
    }
}
