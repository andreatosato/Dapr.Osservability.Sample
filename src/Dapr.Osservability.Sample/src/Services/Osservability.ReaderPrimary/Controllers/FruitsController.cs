using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Osservability.ReaderPrimary.Data;
using System.Threading.Tasks;

namespace Osservability.ReaderPrimary.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        private readonly FruitContext db;

        public FruitsController(FruitContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var fruits = await db.Fruits.ToListAsync();
            return Ok(fruits);
        }
    }
}
