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

        public string createID()
        {
            //**Type: POUT000001**/
            try
            {
                List<ProgramOutcome> po = db.ProgramOutcomes.ToList().Where(st => st.id.Substring(0, 4) == "POUT").ToList();
                string max = po.Max(t => t.id);
                int idnumber = int.Parse(max.Substring(5, 6)) + 1;
                string maxId = "POUT" +  idnumber.ToString().PadLeft(6, '0');
                return maxId;
            }
            catch (NullReferenceException)
            {
                return "POUT" + "000001";
            }
        }
        public bool AddProOut(string idp,string no, int type, string content)
        {
            try
            {
                ProgramOutcome poc = new ProgramOutcome();
                poc.id = createID();
                poc.idProgram = idp;
                poc.OutcomeNo = no;
                poc.OutcomeType = type;
                poc.OutcomeContent = content;
                db.ProgramOutcomes.InsertOnSubmit(poc);
                db.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool EditProOut(string id, string no, int type, string content)
        {
            try
            {
                ProgramOutcome poe = db.ProgramOutcomes.Where(po => po.id == id).Single();
                poe.OutcomeNo = no;
                poe.OutcomeContent = content;
                poe.OutcomeType = type;
                db.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

    }
}
