﻿using System;
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

       

        public bool Updatelecturer(string id, string content)
        {
            try
            {
                Program lec = db.Programs.Where(st => st.id == id).Single();
                lec.ProgramLecturer = content;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool getLock(string id)
        {
            try
            {
                return db.Programs.Where(proram => proram.id == id).Single().isLock.Value;

            }
            catch
            {
                return true;
            }
        }
        public void setlock(string id)
        {
            Program program = db.Programs.Where(proram => proram.id == id).Single();
            program.isLock = true;
        }
        public void unlock(string id)
        {
            Program program = db.Programs.Where(proram => proram.id == id).Single();
            program.isLock = false;

        }
        public bool UpdatePackage(string id, string content)
        {
            try
            {
                Program lec = db.Programs.Where(st => st.id == id).Single();
                lec.ProgramPackage = content;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }



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
                pr.isLock = false;
                pr.ProgramActor = "";
                pr.ProgramBranch = "";
                pr.ProgramLecturer = "";
                pr.ProgramLevel = "";
                pr.ProgramPackage = "";
                pr.ProgramPackage = "";
                pr.ProgramPoint = 0;
                pr.ProgramProcess = "";
                pr.ProgramSemester = 0;
                pr.ProgramTC = 0;
                pr.ProgramTime = "";
                pr.ProgramVolume = "";
                pr.ProgramType = "";
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
        public bool getcheckcan(string id)
        {
            try
            {
                Program p = db.Programs.Where(a => a.id == id).Single();
                if (p.ProgramSemester == null || p.ProgramSemester.ToString() == "" || p.ProgramSemester.ToString() == null)
                {
                    return false;
                }
                else if (p.ProgramTC == null || p.ProgramTC.ToString() == "" || p.ProgramTC.ToString() == null)
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
