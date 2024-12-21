using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tree.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //תאגיד
    public class CorporationController : ControllerBase
    {
        // GET: api/<CorporationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CorporationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CorporationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CorporationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CorporationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
