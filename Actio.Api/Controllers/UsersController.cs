using System;
using System.Threading.Tasks;
using Actio.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Actio.Api.Controllers
{
    [Route("[Controller]")]
    public class UsersController : Controller
    {
        private readonly IBusClient _busClient;
        public UsersController(IBusClient busClient) 
        {
            _busClient = busClient;
        }
        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]CreateUser command)
        {
            try
            {
                await _busClient.PublishAsync(command);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error " +e);
            }
            return Accepted();
        }
        
    }
}