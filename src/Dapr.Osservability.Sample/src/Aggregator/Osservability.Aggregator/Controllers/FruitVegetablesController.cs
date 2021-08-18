using Dapr.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
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
            var random = new Random().Next(0, 100);
            var randomizeResponse = random <= 50;
            _logger.LogInformation($"Random: {randomizeResponse}");
            if (randomizeResponse)
            {
                var fruits = await client.InvokeMethodAsync<List<FruitVegetable>>(HttpMethod.Get, "osservability-readerprimary", "Fruits");
                return Ok(fruits);
            }
            else
            {
                var vegetables = await client.InvokeMethodAsync<List<FruitVegetable>>(HttpMethod.Get, "osservability-readersecondary", "Vegetables");
                return Ok(vegetables);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(FruitVegetable fruitVegetable)
        {
            _logger.LogInformation("Insert random data");
            await client.InvokeMethodAsync("osservability-writer", "FruitVegetable", fruitVegetable);

            return Ok();
        }
    }
}
