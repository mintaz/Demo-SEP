using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Text.RegularExpressions;

namespace BLL
{
    public class LoginBLL
    {
        //connection
        EprogramDataContext db = new EprogramDataContext();
        // end connection

        //check Email
        public bool isvaildEmail(string email)
        {
            try
            {
                 if(Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase) == true)
                {
                    return true;
                }
                 else
                { return false; }
                //var addr = new System.Net.Mail.MailAddress(email);
                //return addr.Address == email;
                
            }
            catch
            {
                return false;
            }
        }

        //check vaild Account
        public bool isvaildAccount(string user)
        {
            try
            {
                db.Accounts.Where(ac => ac.email == user).Single();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //check Password
        public bool isvaildPass (string user, string pass)
        {
            try
            {
                db.Accounts.Where(ac => ac.email == user && ac.password == pass).Single();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        //check Admin
        public bool isAdmin (string user)
        {
            try
            {
                db.Accounts.Where(ac => ac.email == user && ac.isAdmin == true).Single();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //check Active
        public bool isActive(string user)
        {
            try
            {
                db.Accounts.Where(ac => ac.email == user && ac.Active == true).Single();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //get ID
        public string getID( string user)
        {
            try
            {
                return db.Accounts.Where(ac => ac.email == user).FirstOrDefault().id;
            }
            catch (Exception)
            {
                return "error";
            }
        }
        //count
        public bool isCount(string id)
        {
            try
            {
                int p = db.Programs.Where(procount => procount.idAccount == id).Count();
                int s = db.Syllabus.Where(syllbuscount => syllbuscount.idAccount == id).Count();
                if ((p == s) && (s == 0))
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
        //getname
        public string getnameprogram(string id)
        {
            Program p = db.Programs.Where(s => s.id == id).Single();
            return p.name;
        }

        public string getnamesyllabus(string id)
        {
            Syllabus s = db.Syllabus.Where(t => t.id == id).Single();
            return s.name;
        }

    }
}
