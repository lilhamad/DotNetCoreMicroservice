using Microsoft.AspNetCore.Mvc;

namespace Actio.Api.Controllers
{
    [Route("[Controller]")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get()
        =>Content("Hello From Actio API");
        
    }
}