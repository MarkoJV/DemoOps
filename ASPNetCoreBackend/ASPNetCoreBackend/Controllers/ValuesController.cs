using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNetCoreBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>

        /*[HttpGet]
        public int num()
        {
            return 123;
        }*/

        /*[HttpGet]
        public IEnumerable<int> Get()
        {
            return new int[] { 7 };
        }*/

        /*[HttpGet]
        public IEnumerable<String> Get()
        {
            return new string[] { "Text1", "Text2", "Text3" };
        }*/

        [HttpGet]
        public Values Values()
        {
            var rng = new Random();
            return new Values()
            {
                Value = rng.Next(1, 101)
            };
        }

        // GET api/<ValuesController>/5
        /*[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
