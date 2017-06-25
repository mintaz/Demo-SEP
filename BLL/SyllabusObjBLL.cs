using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class SyllabusObjBLL
    {
        EprogramDataContext db = new EprogramDataContext();
        public List<SyllabusObjective> loadlistobj(string id)
        {
            return db.SyllabusObjectives.Where(s => s.idSyllabus == id).ToList();
        }
        
    }
}
