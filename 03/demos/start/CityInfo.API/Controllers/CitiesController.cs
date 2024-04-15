using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase 
    {
        public JsonResult GetCities()
        {
            new JsonResult(
                new List<Object>
                {
                    new {id=1 , Name = "New York City"},
                    new {id=2 , Name = "Newstrep"}
                });
        }
    }
}
