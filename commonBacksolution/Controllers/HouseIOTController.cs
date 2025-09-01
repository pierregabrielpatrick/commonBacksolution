using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace commonBacksolution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseIOTController : ControllerBase
    {

        [HttpGet]           
        public ActionResult GetHouses() {
        

            return Ok();
        }
    }
}
