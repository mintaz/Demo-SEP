using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ResetBLL
    {
        EprogramDataContext db = new EprogramDataContext();
        public bool successUpdate(string user, string pass)
        {
            try
            {
                Account acc = db.Accounts.Where(ac => ac.email == user).SingleOrDefault();
                acc.password = pass;
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
