using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class KeysController : Controller
    {
        // GET api/keys
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "key1", "key2" };
        }

        // GET api/keys/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "key"+id;
        }

        // POST api/keys
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/keys/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/keys/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
