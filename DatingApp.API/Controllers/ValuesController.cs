using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
      
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1","value2"};
        }

          [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            
            return "value";
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
