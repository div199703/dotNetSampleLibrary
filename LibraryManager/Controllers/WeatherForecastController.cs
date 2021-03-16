using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Service running";
        }
    }
}
