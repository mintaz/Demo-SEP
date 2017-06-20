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
                db.Accounts.Where(ac => ac.email == user).SingleOrDefault();
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
                db.Accounts.Where(ac => ac.email == user && ac.password == pass).SingleOrDefault();
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
                db.Accounts.Where(ac => ac.email == user && ac.isAdmin == true).SingleOrDefault();
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
                db.Accounts.Where(ac => ac.email == user && ac.Active == true).SingleOrDefault();
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
        
    }
}
