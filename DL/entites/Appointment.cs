namespace DL.entites
{
    public class Appointment
    {
        public int Id { get; set; }
        public int IdBaby { get; set; }
        public string Description { get; set; }
       // public DateOnly Date { get; set; }  
        public int IdNurse { get; set; }

        public Appointment( int id,int idBaby, string description, int idNurse)//DateOnly date
        {
            Id = id;
            IdBaby = idBaby;
            Description = description;
          //  Date = date;
            IdNurse = idNurse;
        }
    }
}
