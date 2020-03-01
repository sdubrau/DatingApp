using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
      public ValuesController(DataContext context)
      {
          _context=context;
      }
        private readonly ILogger<ValuesController> _logger;


        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

          [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(e=>e.Id==id);
            return Ok(value);
        }

          [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
        }
         [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
