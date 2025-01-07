namespace DL.entites
{
    public class Baby
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // public DateOnly dateOfBirth {get;set;}
       // public List<Appointment> medicalFile { get; set; }

        public Baby(int id, string name)// , DateOnly dateOfBirth,List<Appointment> medicalFile
        {
            Id = id;
            Name = name;
            //this.dateOfBirth = dateOfBirth;
           // this.medicalFile = medicalFile;
        }

    }
}
