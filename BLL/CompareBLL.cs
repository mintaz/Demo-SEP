using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class CompareBLL
    {
        EprogramDataContext db = new EprogramDataContext();
        public bool Compare2string(string oldstring, string newstring)
        {
            if (oldstring == newstring)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool changeName(string id,string name)
        {
            try
            {
                Account acname = db.Accounts.Where(ac => ac.id == id).SingleOrDefault();
                acname.name = name;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool changepass(string id, string pass)
        {
            try
            {
                Account acpass = db.Accounts.Where(ac => ac.id == id).SingleOrDefault();
                acpass.password = pass;
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
