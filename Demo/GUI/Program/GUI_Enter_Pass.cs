using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
namespace Demo.GUI.Program
{
    public partial class GUI_Enter_Pass : Form
    {
        public GUI_Enter_Pass()
        {
            InitializeComponent();
        }
        EncryptBLL en = new EncryptBLL();
        AccountBLL acc = new AccountBLL();
        ProgramBLL p = new ProgramBLL();
        public string idprogram = "";
        EprogramDataContext db = new EprogramDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            string pass = textBox1.Text;
            string iac = db.Programs.Where(s => s.id == idprogram).Single().idAccount;
            string accpass = db.Accounts.Where(ac => ac.id == iac).Single().password;
            if (en.EncodeSHA1(pass) == accpass)
            {
                p.unlock(idprogram);
                MessageBox.Show("Chương trình đã mở khóa.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu.");
            }
        }

    }
}
