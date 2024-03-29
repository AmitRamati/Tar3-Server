﻿using Microsoft.AspNetCore.Mvc;
using Tar2.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tar2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacationsController : ControllerBase
    {
        // GET: api/<VacationsController>
        [HttpGet]
        public IEnumerable<Vacation> Get()
        {
            Vacation v = new Vacation();
            return v.Read();

        }

        [HttpGet("getByDates/startDate/{startDate}/endDate/{endDate}")]
        public IEnumerable<Vacation> GetByDate(DateTime startDate, DateTime endDate) 
        {
            var v = new Vacation();  
            return v.GetByDate(startDate, endDate);
        }

  

        // GET api/<VacationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VacationsController>
        [HttpPost]
        public int Post([FromBody] Vacation v)
        {
            return v.Insert();
        }

        // PUT api/<VacationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VacationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
