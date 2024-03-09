using Microsoft.AspNetCore.Mvc;
using Tar3.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tar3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable <User> Get()
        {
            User u = new User();
            return u.Read();
        }

        [HttpGet("AveragePrice")]
        public Object getAverage(int month)
        {
            DBservices dbs = new DBservices();
            List<Object> ObjectList = dbs.GetAveragePricePerMonth(month);
            return ObjectList;

        }



        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // POST api/<UsersController>
        [HttpPost]
        public int Post([FromBody] User u)
        {
            return u.Insert();
        }


     

        // PUT api/<UsersController>/5
        [HttpPut]
        public int Put([FromBody] User u)
        {
            return u.Update();

        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
