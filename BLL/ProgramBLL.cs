using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; 
namespace BLL
{
    public class ProgramBLL
    {
        EprogramDataContext db = new EprogramDataContext();

        public string createID()
        {
            try
            {
                List<Program>pro = db.Programs.ToList().Where(st => st.id.Substring(0, 2) == "PR").ToList();
                string max = pro.Max(t => t.id);
                int idnumber = int.Parse(max.Substring(2, 4)) + 1;
                string maxId = "PR" + idnumber.ToString().PadLeft(4, '0');
                return maxId;
            }
            catch (NullReferenceException)
            {
                return "PR" + "0001";
            }
        }
        public bool CreateProgram(string idAcc,string namepro)
        {
            try
            {
                Program pr = new Program();
                pr.id = createID();
                pr.name = namepro;
                pr.idAccount = idAcc;
                db.Programs.InsertOnSubmit(pr);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditProgram(string id, string name,string idacc)
        {
            try
            {
                Program editpro = db.Programs.Where(edit => edit.id == id).Single();
                editpro.name = name;
                editpro.idAccount = idacc;
                db.SubmitChanges();
                return true;
                
            }catch
            {
                return false;
            }
        }
        public List<Program> Load()
        {
            return db.Programs.ToList();
        }
        public List<Program> LoadProgram(string id)
        {
            return db.Programs.Where(a => a.id == id).ToList();
        }
        public bool UpdateProgram(string id,string programlevel, string programbranch, string programtype, string programtime, string programactor, string programvolume, string programprocess, int programpoint, int programsem, int programmark)
        {
            try
            {
                Program p = db.Programs.Where(a => a.id == id).Single();
                p.ProgramLevel = programlevel;
                p.ProgramBranch = programbranch;
                p.ProgramType = programtype;
                p.ProgramTime = programtime;
                p.ProgramActor = programactor;
                p.ProgramVolume = programvolume;
                p.ProgramProcess = programprocess;
                p.ProgramPoint = programmark;
                p.ProgramTC = programpoint;
                p.ProgramSemester = programsem;


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
