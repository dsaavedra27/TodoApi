using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly DataContext _context;

        public DataController(DataContext context)
        {
            _context = context;

            if (_context.DataItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.DataItems.Add(new DataItem { Department = "Item1" });
                _context.SaveChanges();
            }
        }
        // GET: api/Todo
        [HttpGet ("data.cabq.gov/government/top250/Top250EarnersCABQ2018-en-us.csv")]
        public async Task<ActionResult<IEnumerable<DataItem>>> GetDataItems()
        {
            return await _context.DataItems.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataItem>> GetDataItem(long Id)
        {
            var dataItem = await _context.DataItems.FindAsync(Id);

            if (dataItem == null)
            {
                return NotFound();
            }

            return dataItem;
        }
        // PUT: api/Todo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDataItem(long id, DataItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}