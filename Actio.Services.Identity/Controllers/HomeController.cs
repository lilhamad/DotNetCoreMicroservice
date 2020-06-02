using Actio.Common.Mongo;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Actio.Services.Identity.Controllers
{
    //[Route("[Controller]")]
    public class HomeController : Controller
    {
        private readonly IDatabaseInitializer _databaseInitializer;
        public HomeController(IDatabaseInitializer databaseInitializer)
        {
            _databaseInitializer = databaseInitializer;
        }
        //[HttpGet("")]
        public async Task<IActionResult> New()
        {
            await _databaseInitializer.InitializeAsync();
            return Accepted();
        }
    }
}