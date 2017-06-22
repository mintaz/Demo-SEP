using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class AccountBLL
    {
        //load db and dictionaries
        EprogramDataContext db = new EprogramDataContext();
        EncryptBLL en = new EncryptBLL();
        DicBLL dic = new DicBLL();


        //load Account
        public List<Account> LoadAccount()
        {
            return db.Accounts.ToList();
        }
        //Auto create ID
        public string createID()
        {
            string year = (DateTime.Now.Year % 100).ToString();

            try
            {
                List<Account> ac = db.Accounts.ToList().Where(st => st.id.Substring(1, 2) == year).ToList();
                string max = ac.Max(t => t.id);
                int idnumber = int.Parse(max.Substring(3, 4)) + 1;
                string maxId = "T" + year + idnumber.ToString().PadLeft(4, '0');
                return maxId;
            }
            catch (NullReferenceException)
            {
                return "T" + year + "0001";
            }
        }

        //add Account 
        public bool AddAccount(string user, string name, bool isadmin, bool active)
        {
            try
            {
                
                Account accAdd = new Account();
                accAdd.id = createID();
                accAdd.email = user;
                accAdd.password = en.EncodeSHA1(dic.defaultPass());
                accAdd.name = name;
                accAdd.isAdmin = isadmin;
                accAdd.Active = active;

                db.Accounts.InsertOnSubmit(accAdd);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Edit Account
        public bool EditAccount(string id, string user, string name, bool isadmin, bool active)
        {
            try
            {
                Account accedit = db.Accounts.Where(ac => ac.id == id).Single();
                accedit.email = user;
                accedit.name = name;
                accedit.isAdmin = isadmin;
                accedit.Active = active;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        //load User
        public List<Account> LoadUser(string id)
        {
                return db.Accounts.Where(a => a.id == id).ToList();
        }

        //Delete Account
        public bool DeleteAccount(string idd)
        {
            try
            {
                Account accdel = db.Accounts.Where(ad => ad.id == idd).Single();
                db.Accounts.DeleteOnSubmit(accdel);
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
