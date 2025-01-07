//using DL.entites;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DL
//{
//    internal class FaceData:IDataContext
//    {
//        public List<Baby> Babies
//        {
//            get { return _babies; }
//            set { _babies = value; }
//        }

//        public List<Nurse> Nurses
//        {
//            get { return _nurses; }
//            set { _nurses = value; }
//        }

//        public List<Appointment> Appointments
//        {
//            get { return _appointments; }
//            set { _appointments = value; }
//        }


//        private List<Baby> _babies = new List<Baby>();
//        private List<Nurse> _nurses = new List<Nurse>();
//        private List<Appointment> _appointments = new List<Appointment>();

//       public FaceData()
//        {
//            Baby b1 = new Baby(1, "Yael", new DateOnly(2023, 11, 4), new List<Appointment>());
//            Baby b2 = new Baby(2, "Dvora", new DateOnly(2023, 10, 4), new List<Appointment>());
//            Baby b3 = new Baby(3, "Ester", new DateOnly(2023, 11, 4), new List<Appointment>());
//            Baby b4 = new Baby(4, "Ruth", new DateOnly(2023, 10, 4), new List<Appointment>());
//            Baby b5 = new Baby(5, "Yosef", new DateOnly(2023, 11, 4), new List<Appointment>());
//            Baby b6 = new Baby(6, "Chana", new DateOnly(2023, 10, 4), new List<Appointment>());
//            _babies.Add(b1);
//            _babies.Add(b2);
//            _babies.Add(b3);
//            _babies.Add(b4);
//            _babies.Add(b5);
//            _babies.Add(b6);

//            Nurse n1 = new Nurse(1, "Miki", "a", new List<Appointment>());
//            Nurse n2 = new Nurse(2, "Danit", "b", new List<Appointment>());
//            Nurse n3 = new Nurse(3, "Ronith", "c", new List<Appointment>());
//            _nurses.Add(n1);
//            _nurses.Add(n2);
//            _nurses.Add(n3);
//            Appointment a1 = new Appointment(1, 1, "blood", new DateOnly(2024, 05, 24), 2);
//            Appointment a2 = new Appointment(2, 1, "blood", new DateOnly(2024, 05, 24), 2);
//            Appointment a3 = new Appointment(3, 1, "blood", new DateOnly(2024, 05, 24), 2);
//            Appointment a4 = new Appointment(4, 1, "blood", new DateOnly(2024, 05, 24), 2);
//            _appointments.Add(a1);
//            _appointments.Add(a2);
//            _appointments.Add(a3);
//        }
//    }
//}
