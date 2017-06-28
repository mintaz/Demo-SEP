using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class SyllabusOutBLL
    {
        EprogramDataContext db = new EprogramDataContext();
        MappingBLL mapz = new MappingBLL();
        public int getCount(string ids)
        {
            try
            {
                int s = db.SyllabusOutcomes.Where(st => st.idSyllabus == ids).Count();
                return s;
            }
            catch
            {
                return 0;
            }
        }
        public List<SyllabusOutcome> loadlistout(string id)
        {
            return db.SyllabusOutcomes.Where(s => s.idSyllabus == id).ToList();
        }
        public List<SyllabusOutcome> loadout(string idout)
        {
            return db.SyllabusOutcomes.Where(s => s.id == idout).ToList();
        }

       
        public string currentID = "";
        public string createID()
        {
            try
            {
                //**Type: SYOU000001**//
                List<SyllabusOutcome> ac = db.SyllabusOutcomes.ToList().Where(st => st.id.Substring(0, 4) == "SYOU").ToList();
                string max = ac.Max(t => t.id);
                int idnumber = int.Parse(max.Substring(4, 6)) + 1;
                string maxId = "SYOU" + idnumber.ToString().PadLeft(6, '0');
                return maxId;
            }
            catch (NullReferenceException)
            {
                return "SYOU" + "000001";
            }
        }
        public bool AddOut(string ids, string no, string content)
        {
            try
            {
                SyllabusOutcome outadd = new SyllabusOutcome();
                currentID = createID();
                outadd.id = currentID;
                outadd.idSyllabus = ids;
                outadd.OutcomeNo = no;
                outadd.OutcomeContent = content;
                mapz.AddMap(ids, currentID, "");
                db.SyllabusOutcomes.InsertOnSubmit(outadd);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditOut(string id, string no, string content)
        {
            try
            {
                SyllabusOutcome outedit = db.SyllabusOutcomes.Where(edit => edit.id == id).Single();
                outedit.OutcomeNo = no;
                outedit.OutcomeContent = content;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DelOut(string id)
        {
            try
            {
                SyllabusOutcome outdel = db.SyllabusOutcomes.Where(del => del.id == id).Single();
                mapz.DelMap(id);
                db.SyllabusOutcomes.DeleteOnSubmit(outdel);
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
