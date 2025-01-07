using DL;
using DL.entites;

namespace BL
{
    public class BabyService:IBabeService
    {
        private readonly IDataContext _dataContext;
        public  BabyService(IDataContext data)
        {
            _dataContext = data;
        }
       
        public void AddBabyToList(Baby b)
        {
            _dataContext.Babies.Add(b);
        }
        public void DeleteBabyFromList(int id)
        {
            if(id <= 0)
            {
                throw new Exception("not valid - negative number id");
            }
            Baby b = _dataContext.Babies.Where(x => x.Id == id).FirstOrDefault();
            _dataContext.Babies.Remove(b);
        }
        public List<Baby> GetList()
        {

            return _dataContext.Babies.ToList() ;
        }
        public Baby GetBabyById(int id)
        {

            if (id <= 0)
            {
                throw new Exception("not valid - negative number id");
            }

            return _dataContext.Babies.Where(x => x.Id == id).FirstOrDefault();
        }
        public void UpdateBabyById(Baby a, int idBaby)
        {
            _dataContext.Babies.Where(x => x.Id == idBaby).FirstOrDefault();
        }
    }
}
