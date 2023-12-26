using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        //api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" ,"..!"};
        }

        // GET api/<ValuesController>/5
        //api/values/1
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value"+id;
        }

        // POST api/<ValuesController>
        //api//values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        //api/values/1
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        //api/values/1
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
