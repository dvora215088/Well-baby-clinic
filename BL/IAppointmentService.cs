using DL.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IAppointmentService
    {
        void UpdateAppointmentById(Appointment a, int id);
        Appointment GetAppointmentById(int id);
        List<Appointment> GetList();
        void DeleteAppointmentFromList(int id);
        void AddAppointmentToList(Appointment a);
    }
}
