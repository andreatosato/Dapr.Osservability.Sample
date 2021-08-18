using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Osservability.ReaderPrimary.Data;
using Osservability.ReaderPrimary.Data.Models;
using Osservability.ReaderSecondary.Data;
using Osservability.ReaderSecondary.Data.Models;
using System.Threading.Tasks;

namespace Osservability.Writer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitVegetableController : ControllerBase
    {
        private readonly ILogger<FruitVegetableController> _logger;
        private readonly FruitContext fruitDb;
        private readonly VegetableContext vegetableDb;

        public FruitVegetableController(ILogger<FruitVegetableController> logger,
            FruitContext fruitDb, VegetableContext vegetableDb)
        {
            _logger = logger;
            this.fruitDb = fruitDb;
            this.vegetableDb = vegetableDb;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(FruitVegetable fruitVegetable)
        {
            switch (fruitVegetable.Type)
            {
                case FruitVegetableType.Fruit:
                    var fruitEntity = new FruitEntity
                    {
                        Name = fruitVegetable.Name,
                        Description = fruitVegetable.Description,
                        Quantity = fruitVegetable.Quantity,
                        Temperature = fruitVegetable.Temperature,
                        ExpirationDate = fruitVegetable.ExpirationDate
                    };
                    fruitDb.Add(fruitEntity);
                    await fruitDb.SaveChangesAsync();
                    break;
                case FruitVegetableType.Vegetable:
                    var vegetableEntity = new VegetableEntity
                    {
                        Name = fruitVegetable.Name,
                        Description = fruitVegetable.Description,
                        Quantity = fruitVegetable.Quantity,
                        Temperature = fruitVegetable.Temperature,
                        ExpirationDate = fruitVegetable.ExpirationDate
                    };
                    vegetableDb.Add(vegetableEntity);
                    await vegetableDb.SaveChangesAsync();
                    break;
            }
            return Ok();
        }
    }
}
