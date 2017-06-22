using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class SyllabusBLL
    {
        EprogramDataContext db = new EprogramDataContext();

        public List<Syllabus> loadSyllabus(string idprogram)
        {
            return db.Syllabus.Where(s =>s.idProgram==idprogram).ToList();
        }
    }
}
