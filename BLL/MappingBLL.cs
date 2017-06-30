using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class MappingBLL
    {
        EprogramDataContext db = new EprogramDataContext();
        public List<SyllabusOutcome> loadSyOut(string idS)
        {
            return db.SyllabusOutcomes.Where(st => st.idSyllabus == idS).ToList();
        }
        public List<ProgramOutcome> loadPrOut(string idP)
        {
            return db.ProgramOutcomes.Where(st => st.idProgram== idP).ToList();
        }

        public List<Mapping> listmap(string idS)
        {
            return db.Mappings.Where(st => st.idSyllabus == idS).ToList();
        }
        public List<Mapping> singlemap (string idmap)
        {
            return db.Mappings.Where(st => st.id == idmap).ToList();
        }

        public int getCount(string ids)
        {
            try
            {
                int s = db.Mappings.Where(st => st.idSyllabus == ids).Count();
                return s;
            }
            catch
            {
                return 0;
            }
        }
        public bool UpdateMethod(string idmap, string method, string p1, string p2,string p3, int per1,int per2, int per3, int des)
        {
            try
            {
                Mapping manup = db.Mappings.Where(ma => ma.id == idmap).Single();
                manup.Methods = method;
                manup.FirstPart = p1;
                manup.SecondPart = p2;
                manup.ThirdPart = p3;
                manup.FirstPercent = per1;
                manup.SecondPercent = per2;
                manup.ThirdPercent = per3;
                manup.desity = des;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public string createMapID()
        {
            try
            {
                //**Type: MAPP000001**//
                List<Mapping> ac = db.Mappings.ToList().Where(st => st.id.Substring(0, 4) == "MAPP").ToList();
                string max = ac.Max(t => t.id);
                int idnumber = int.Parse(max.Substring(4, 6)) + 1;
                string maxId = "MAPP" + idnumber.ToString().PadLeft(6, '0');
                return maxId;
            }
            catch (NullReferenceException)
            {
                return "MAPP" + "000001";
            }
        }

        public bool AddMap (string idS,string sys, string program)
        {
            try
            {
                Mapping addmap = new Mapping();
                addmap.id = createMapID();
                addmap.idSyllabus = idS;
                addmap.ProgramOutcome = program;
                addmap.SyllabusOutcome = sys;
                addmap.desity = 0;
                db.Mappings.InsertOnSubmit(addmap);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string createString(List<string> listid)
        {
            try
            {
                string line = String.Join(",", listid);
                return line;
            }
            catch
            {
                return "";
            }
        }
        //chuyển chuỗi ID trong db thành list
        public List<string> loadcheckedlist(string line)
        {
            try
            {
                return line.Split(',').ToList();
            }
            catch
            {
                return new List<string>();
            }
        }

        public void DelMapfromSyOut(string idOut)
        {
            Mapping mapdel2 = db.Mappings.Where(del => del.SyllabusOutcome == idOut).Single();
            db.Mappings.DeleteOnSubmit(mapdel2);
            db.SubmitChanges();
        }


        public bool DelMap(string idS)
        {
            try
            {
                Mapping mapdel = db.Mappings.Where(z => z.idSyllabus == idS).Single();
                db.Mappings.DeleteOnSubmit(mapdel);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public string loadmap(string sts)
        {
            try
            {
                return db.Mappings.Where(s => s.SyllabusOutcome == sts).Single().ProgramOutcome;
            }
            catch
            {
                return "";
            }
        }
        public bool ChangePro(string sts, string stp)
        {
            try
            {
                Mapping map = db.Mappings.Where(s => s.SyllabusOutcome == sts).Single();
                map.ProgramOutcome = stp;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool checkexistid(string sts)
        {
            try
            {
                int check = db.Mappings.Where(s => s.SyllabusOutcome == sts).Count();
                if(check > 0)
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


    }
}
