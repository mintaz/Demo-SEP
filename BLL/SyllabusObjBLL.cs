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
        public List<SyllabusObjective> loadobj (string idobj)
        {
            return db.SyllabusObjectives.Where(obj => obj.id == idobj).ToList();
        }
        public string createID()
        {
            try
            {
                //**Type: POBJ000001**//
                List<SyllabusObjective> ac = db.SyllabusObjectives.ToList().Where(st => st.id.Substring(0, 4) == "POBJ").ToList();
                string max = ac.Max(t => t.id);
                int idnumber = int.Parse(max.Substring(4, 6)) + 1;
                string maxId = "POBJ" + idnumber.ToString().PadLeft(6, '0');
                return maxId;
            }
            catch (NullReferenceException)
            {
                return "POBJ" + "000001";
            }
        }
        public bool AddObj (string ids, string content)
        {
            try
            {
                SyllabusObjective addobj = new SyllabusObjective();
                addobj.id = createID();
                addobj.idSyllabus = ids;
                addobj.ObjSContent = content;
                db.SyllabusObjectives.InsertOnSubmit(addobj);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditObj (string id, string content)
        {
            try
            {
                SyllabusObjective ediobj = db.SyllabusObjectives.Where(edit => edit.id == id).Single();
                ediobj.ObjSContent = content;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DelObj (string id)
        {
            try
            {
                SyllabusObjective delobj = db.SyllabusObjectives.Where(del => del.id == id).Single();
                db.SyllabusObjectives.DeleteOnSubmit(delobj);
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
