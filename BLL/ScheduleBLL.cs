using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Reflection;

namespace BLL
{
    public class ScheduleBLL
    {
        EprogramDataContext db = new EprogramDataContext();

        public List<SyllabusSchedule> SingleSche(string id)
        {
            return db.SyllabusSchedules.Where(s => s.id == id).ToList();
        }
        public List<SyllabusSchedule> ListSche(string idS)
        {
            return db.SyllabusSchedules.Where(s => s.idSyllabus == idS).ToList();
        }

        public bool isEdit(string id, int number)
        {
            try
            {
                SyllabusSchedule sc = db.SyllabusSchedules.Where(sz => sz.id == id).Single();
                if(sc.NumberPeriods == number)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public string getsto(string idS)
        {
            try
            {
                int count = 0;
                foreach (SyllabusSchedule item in db.SyllabusSchedules.Where(st => st.idSyllabus == idS))
                {
                    count += item.NumberPeriods.Value;
                }
                int total = (db.Syllabus.Where(st => st.id == idS).Single().CoursePoint.Value) * 15;
                int stor = total - count;
                return stor.ToString();
            }
            catch
            {
                return "0";
            }
        }
        public bool check(string idS, int period)
        {
            try
            {
                int count = 0;
                foreach (SyllabusSchedule item in db.SyllabusSchedules.Where(st => st.idSyllabus == idS))
                {
                    count += item.NumberPeriods.Value;
                }
                int total = (db.Syllabus.Where(st => st.id == idS).Single().CoursePoint.Value) * 15;
                int stor = total - count;
                if (period > stor)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        string createScheID()
        {
            try
            {
                //**Type: SS0000000001**//
                List<SyllabusSchedule> ac = db.SyllabusSchedules.ToList().Where(st => st.id.Substring(0, 2) == "SS").ToList();
                string max = ac.Max(t => t.id);
                int idnumber = int.Parse(max.Substring(2, 10)) + 1;
                string maxId = "SS" + idnumber.ToString().PadLeft(10, '0');
                return maxId;
            }
            catch (NullReferenceException)
            {
                return "SS" + "0000000001";
            }
        }
        public bool AddSche(string idS, DateTime date,int number, string content, string acitve, string doc, bool mid)
        {
            try
            {
                SyllabusSchedule addsche = new SyllabusSchedule();
                addsche.id = createScheID();
                addsche.idSyllabus = idS;
                addsche.Day = date;
                addsche.NumberPeriods = number;
                addsche.LectureContent = content;
                addsche.Activites = acitve;
                addsche.Doc = doc;
                addsche.mid = mid;
                db.SyllabusSchedules.InsertOnSubmit(addsche);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditSche(string id, DateTime date, int number, string content, string acitve, string doc, bool mid)
        {
            try
            {
                SyllabusSchedule editsche = db.SyllabusSchedules.Where(ss => ss.id == id).Single();
                editsche.Day = date;
                editsche.NumberPeriods = number;
                editsche.LectureContent = content;
                editsche.Activites = acitve;
                editsche.Doc = doc;
                editsche.mid = mid;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelSche(string id)
        {
            try
            {
                SyllabusSchedule delsche = db.SyllabusSchedules.Where(ss => ss.id == id).Single();
                db.SyllabusSchedules.DeleteOnSubmit(delsche);
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
