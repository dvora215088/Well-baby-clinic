using BL;
using Microsoft.AspNetCore.Mvc;
using DL.entites;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tipat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly INurseService _nurseService;
        public NurseController(INurseService nurseService)
        {
            _nurseService = nurseService;
        }
        // GET: api/<NurseController>
        [HttpGet]
        public List<Nurse> Get()
        {
            return _nurseService.GetList();
        }

        // GET api/<NurseController>/5
        [HttpGet("{id}")]
        public Nurse Get(int id)
        {
            return _nurseService.GetNuresById(id);
        }

        // POST api/<NurseController>
        [HttpPost]
        public void Post(Nurse value)
        {
            _nurseService.AddNuresToList(value);
        }

        // PUT api/<NurseController>/5
        [HttpPut("{id}")]
        public void Put(int id, Nurse value)
        {
            _nurseService.UpdateNuresById(value, id);   
        }

        // DELETE api/<NurseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _nurseService.DeleteNuresFromList(id);
        }
    }
}
