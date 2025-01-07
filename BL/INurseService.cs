using DL;
using DL.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface INurseService
    {
        List<Nurse> GetList();
        void DeleteNuresFromList(int id);
        void AddNuresToList(Nurse n);
        void UpdateNuresById(Nurse a, int idNurse);
        Nurse GetNuresById(int id);
    }
}
