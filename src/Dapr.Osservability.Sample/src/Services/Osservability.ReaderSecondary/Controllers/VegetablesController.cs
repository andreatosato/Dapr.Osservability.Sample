using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Osservability.ReaderSecondary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VegetablesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {

            return Ok();
        }
    }
}
