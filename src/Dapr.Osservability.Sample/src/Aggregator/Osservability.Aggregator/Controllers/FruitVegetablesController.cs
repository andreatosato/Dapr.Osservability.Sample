using Dapr.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Osservability.Aggregator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitVegetablesController : ControllerBase
    {
        private readonly ILogger<FruitVegetablesController> _logger;
        private readonly DaprClient client;

        public FruitVegetablesController(ILogger<FruitVegetablesController> logger, DaprClient client)
        {
            _logger = logger;
            this.client = client;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            _logger.LogInformation("Calling random data");
            var randomizeResponse = Convert.ToBoolean(new Random().Next(0, 1));
            _logger.LogInformation($"Random: {randomizeResponse}");
            if (randomizeResponse)
            {
                var fruits = await client.InvokeMethodAsync<List<FruitVegetable>>("appId", "methodName");
                return Ok(fruits);
            }
            else
            {
                var vegetables = await client.InvokeMethodAsync<List<FruitVegetable>>("appId", "methodName");
                return Ok(vegetables);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(FruitVegetable fruitVegetable)
        {
            _logger.LogInformation("Insert random data");
            await client.InvokeMethodAsync("appId", "methodName", fruitVegetable);

            return Ok();
        }
    }
}
