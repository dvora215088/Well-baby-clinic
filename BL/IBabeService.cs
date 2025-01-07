using DL.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBabeService
    {
        void UpdateBabyById(Baby a, int idBaby);
        Baby GetBabyById(int id);
        List<Baby> GetList();
        void DeleteBabyFromList(int id);
        void AddBabyToList(Baby b);

    }
}
