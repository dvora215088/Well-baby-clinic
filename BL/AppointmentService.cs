using DL.entites;
using DL;

namespace BL
{
    public class AppointmentService:IAppointmentService
    {
        private readonly IDataContext _dataContext;
        public AppointmentService(IDataContext data)
        {
            _dataContext = data;
        }
        public void AddAppointmentToList(Appointment a)
        {

            _dataContext.Appointments.Add(a);
        }
        public void DeleteAppointmentFromList(int id)
        {

            Appointment a = _dataContext.Appointments.Where(x => x.Id == id).FirstOrDefault();
            _dataContext.Appointments.Remove(a);
        }
        public List<Appointment> GetList()
        {

            return _dataContext.Appointments.ToList();
        }
        public Appointment GetAppointmentById(int id)
        {

            return _dataContext.Appointments.Where(x => x.Id == id).FirstOrDefault();
        }
        public void UpdateAppointmentById(Appointment a, int id)
        {

            _dataContext.Appointments.Where(x => x.Id == id).FirstOrDefault();
        }
       
    }
}
