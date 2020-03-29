using System.Threading.Tasks;
using Actio.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Actio.Api .Controllers
{
    [Route("[Controller]")]
    public class ActivitesController : Controller
    {
        private readonly IBusClient _busClient;
        public ActivitesController(IBusClient busClient) 
        {
            _busClient = busClient;
        }
        public async Task<IActionResult> Post([FromBody]CreateActivity command)
        {
            await _busClient.PublishAsync(command);
            return Accepted();
        }
        
    }
}