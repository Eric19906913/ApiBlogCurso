using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiBlog.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetUsers() 
        {
            return Ok();
        }
    }
}
