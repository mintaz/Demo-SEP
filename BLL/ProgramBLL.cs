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

        public List<Program> loadProgramInfo(string idP)
        {
            return db.Programs.
        }
    }
}
