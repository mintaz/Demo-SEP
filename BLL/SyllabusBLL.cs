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

        public int getSememster (string idprogram)
        {
            return db.Programs.Where(sem => sem.id == idprogram).Single().ProgramSemester.Value;
        }
        public List<Syllabus> loadSys(string id)
        {
            return db.Syllabus.Where(s => s.id == id).ToList();
        }
        
        public List<Syllabus> loadpre (string list1)
        {
            string[] ar = list1.Split(',').ToArray();
            //var list = db.Syllabus.Where(s => ar.Contains(s.id)).ToList();
            var list = db.Syllabus.Where(s => ar.Contains(s.id)).Distinct().ToList();
            return list;
        }
        public string AddPre(string line, string id)
        {
            if (line == "")
            {
                line = id;
            }
            else
            {
                line = line + "," + id;
            }
            return line;
        }
        public string DelPre(string line, string id)
        {
            if(line == "")
            {
                return line;
            }
            else
            {
                if (line.Contains(",") == true)
                {
                    string a = "," + id;
                    line = line.Replace(a, "");
                }else
                {
                    line = "";
                }
            }
            return line;
            
        }

        public string CreateID()
        {
            //**Type: SY00000001**//
            try
            {
                List<Syllabus> sys = db.Syllabus.ToList().Where(sy => sy.id.Substring(0, 2) == "SY").ToList();
                string max = sys.Max(t => t.id);
                int idnumber = int.Parse(max.Substring(2, 8)) + 1;
                string maxId = "SY" + idnumber.ToString().PadLeft(8, '0');
                return maxId;
            }
            catch (NullReferenceException)
            {
                return "SY" + "00000001";
            }
        }
        public bool AddSysllabus(string idprogram, string sysname,string syscode, int type, string idac, int sem, int TC, int LT, string precourse, string content)
        {
            try
            {
                Syllabus sys = new Syllabus();
                sys.id = CreateID();
                sys.name = sysname;
                sys.CourseCode = syscode;
                sys.CourseType = type;
                sys.idAccount = idac;
                sys.CourseSemester = sem;
                sys.CoursePoint = TC;
                sys.CourseLT = LT;
                sys.PreCourse = precourse;
                sys.CourseContent = content;
                db.Syllabus.InsertOnSubmit(sys);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool EditPSysllabus(string idsys, string sysname, string syscode, int type, string idac, int sem, int TC, int LT, string precourse, string content)
        {
            try
            {
                Syllabus syspe = db.Syllabus.Where(s => s.id == idsys).Single();
                syspe.name = sysname;
                syspe.CourseCode = syscode;
                syspe.CourseType = type;
                syspe.idAccount = idac;
                syspe.CourseSemester = sem;
                syspe.CoursePoint = TC;
                syspe.CourseLT = LT;
                syspe.PreCourse = precourse;
                syspe.CourseContent = content;
                db.SubmitChanges();
                return true;
            }catch
            {
                return false;
            }
        }
    }
}
