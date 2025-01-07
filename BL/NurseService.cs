using DL.entites;
using DL;

namespace BL
{
    public class NurseService:INurseService
    {
        private readonly IDataContext _dataContext;
        public NurseService(IDataContext data)
        {
            _dataContext = data;
        }
        public void AddNuresToList(Nurse n)
        {

            _dataContext.Nurses.Add(n);
        }
        public void DeleteNuresFromList(int id)
        {

            Nurse n = _dataContext.Nurses.Where(x => x.id == id).FirstOrDefault();
            _dataContext.Nurses.Remove(n);
        }
        public List<Nurse> GetList()
        {

            return _dataContext.Nurses.ToList();
        }
        public Nurse GetNuresById(int id)
        {

            return _dataContext.Nurses.Where(x => x.id == id).FirstOrDefault();
        }
        public void UpdateNuresById(Nurse a, int idNurse)
        {

            _dataContext.Nurses.Where(x => x.id == idNurse).FirstOrDefault();


        }
       
    }
}
