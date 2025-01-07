using BL;
using Microsoft.AspNetCore.Mvc;
using DL.entites;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tipat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService s)
        {
            _appointmentService = s;
        }
        // GET: api/<AppointmentController>
        [HttpGet]
        public List<Appointment> Get()
        {
            return _appointmentService.GetList();
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public Appointment Get(int id)
        {
            return _appointmentService.GetAppointmentById(id);
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public void Post(Appointment v)
        {
            _appointmentService.AddAppointmentToList(v);
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, Appointment v)
        {
            _appointmentService.UpdateAppointmentById(v,id);
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _appointmentService.DeleteAppointmentFromList(id);
        }
    }
}
