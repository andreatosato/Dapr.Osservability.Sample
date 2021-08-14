using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Osservability.Writer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitVegetableController : ControllerBase
    {
        private readonly ILogger<FruitVegetableController> _logger;

        public FruitVegetableController(ILogger<FruitVegetableController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult PostAsync(FruitVegetable fruitVegetable)
        {

            return Ok();
        }
    }
}
