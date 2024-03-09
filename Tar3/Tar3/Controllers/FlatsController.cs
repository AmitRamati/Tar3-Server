using Microsoft.AspNetCore.Mvc;
using Tar2.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tar3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlatsController : ControllerBase
    {
        // GET: api/<FlatsController>
        [HttpGet]
        public IEnumerable<Flat> Get()
        {
            Flat f = new Flat();
            return f.Read();
        }


        // GET api/<FlatsController>/5 by city and price
        [HttpGet("search")]
        public IEnumerable<Flat> GetByCityAndPrice(string city, double price)
        {
            Flat flat = new Flat();
            return flat.GetByCityAndPrice(city, price);
        }


        // POST api/<FlatsController>
        [HttpPost]
        public int Post([FromBody] Flat f)
        {
            return f.Insert();
        }





        // GET api/<FlatsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // PUT api/<FlatsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FlatsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}


