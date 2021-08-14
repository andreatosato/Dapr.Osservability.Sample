using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Osservability.ReaderPrimary.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {

            return Ok();
        }
    }
}
