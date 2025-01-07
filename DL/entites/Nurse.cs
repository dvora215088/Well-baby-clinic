namespace DL.entites
{
    public class Nurse
    {
        public int id {get;set;}
        public string name { get;set;}
        public string medicalField {get;set;}
        //public List<Appointment> ListOfAppointment { get;set;}

        public Nurse(int id, string name, string medicalField) /*List<Appointment> listOfAppointment*/
        {
            this.id = id;
            this.name = name;
            this.medicalField = medicalField;
           // ListOfAppointment = listOfAppointment;
        }
    }
}
