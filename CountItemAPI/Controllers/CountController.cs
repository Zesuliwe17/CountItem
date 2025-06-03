using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CountItemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] List<string> items)
        {
            if (items == null || items.Count == 0)
                return BadRequest("Please send a non-empty list of strings.");

            var counts = ItemCounter.CountItems(items);
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Value}");
            }
            return Ok(counts);
        }
    }
}

