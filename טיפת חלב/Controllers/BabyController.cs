using Microsoft.AspNetCore.Mvc;
using BL;
using DL.entites;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tipat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BabyController : ControllerBase
    {
        private readonly IBabeService b;
        public BabyController(IBabeService s)
        {
            b = s;
        }
        // GET: api/<BabyController>
        [HttpGet]
        public List<Baby> Get()
        {
            return b.GetList();
        }

        // GET api/<BabyController>/5
        [HttpGet("{id}")]
        public Baby Get(int id)
        {
            return b.GetBabyById(id);
        }

        // POST api/<BabyController>
        [HttpPost]
        public void Post([FromBody] Baby value)
        {
            b.AddBabyToList(value);
        }

         //PUT api/<BabyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Baby value)
        {
            b.UpdateBabyById(value,id);
        }

        // DELETE api/<BabyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            b.DeleteBabyFromList(id);
        }
    }
}
