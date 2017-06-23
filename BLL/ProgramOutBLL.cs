using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class ProgramOutBLL
    {
        EprogramDataContext db = new EprogramDataContext();
        public List<ProgramOutcome> LoadPOutcomes (string idp)
        {
            return db.ProgramOutcomes.Where(s => s.id == idp).ToList();
        }
    }
}
