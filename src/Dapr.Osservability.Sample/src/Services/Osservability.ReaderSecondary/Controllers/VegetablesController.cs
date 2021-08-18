using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Osservability.ReaderSecondary.Data;
using System.Threading.Tasks;

namespace Osservability.ReaderSecondary.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VegetablesController : ControllerBase
    {
        private readonly VegetableContext db;

        public VegetablesController(VegetableContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var fruits = await db.Vegetables.ToListAsync();
            return Ok(fruits);
        }
    }
}
