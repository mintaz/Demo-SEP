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

namespace Demo.GUI
{
    public partial class GUI_Account_ResetPass : Form
    {
        public GUI_Account_ResetPass()
        {
            InitializeComponent();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            EncryptBLL encrypt = new EncryptBLL();
            LoginBLL lg = new LoginBLL();
            DicBLL dic = new DicBLL();
            ResetBLL rs = new ResetBLL();
            string user = txtResetPass.Text;
            string pass = encrypt.EncodeSHA1(dic.defaultPass());

            if (lg.isvaildEmail(user) == true)
            {
                if (lg.isvaildAccount(user) == true)
                {
                    if (rs.successUpdate(user, pass) == true)
                    {
                        MessageBox.Show(dic.successResetMessage());
                    }
                    else
                    {
                        MessageBox.Show(dic.errorResetMessage("error"));
                    }
                }
                else
                {
                    MessageBox.Show(dic.errorResetMessage("sai user"));
                }
            }
            else
            {
                MessageBox.Show(dic.errorResetMessage("sai email"));
            }
        }
    }
}
