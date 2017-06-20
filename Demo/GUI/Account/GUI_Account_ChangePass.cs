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
    public partial class GUI_Account_ChangePass : Form
    {
        public GUI_Account_ChangePass()
        {
            InitializeComponent();
        }
        public string idChange = "T170001";
        AccountBLL achange = new AccountBLL();
        EncryptBLL en = new EncryptBLL();
        CompareBLL com = new CompareBLL();
        DicBLL dc = new DicBLL(); 
        private void GUI_Account_ChangePass_Load(object sender, EventArgs e)
        {
            txtname.Text = achange.LoadUser(idChange).SingleOrDefault().name;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string oldname = achange.LoadUser(idChange).SingleOrDefault().name;
            string newname = txtname.Text;
            string oldpass = achange.LoadUser(idChange).SingleOrDefault().password;
            string oldpassinput = en.EncodeSHA1(txtOldPass.Text);
            string newpass = txtNewPass.Text;
            string newpassconfirm = txtNewPassConfirm.Text;
            bool check = false;
            if (com.Compare2string(oldname, newname) == true)
            {
                MessageBox.Show(dc.errorChangeMessage("samename"));
            }
            else
            {
                if((txtOldPass.Text == "") && (txtNewPass.Text == "") && (txtNewPassConfirm.Text == ""))
                {
                    if (com.changeName(idChange, newname) == true)
                    {
                        check = true;
                        MessageBox.Show(dc.successChangeMessage("changename"));
                    
                    }
                    else
                    {
                        MessageBox.Show(dc.successChangeMessage("else"));
                    }
                }
                else
                {
                    if(com.Compare2string(oldpass, oldpassinput) == false){
                        MessageBox.Show(dc.errorChangeMessage("wrongpass"));
                    }
                    else
                    {
                        if (com.Compare2string(txtOldPass.Text, newpass) == true)
                        {
                            MessageBox.Show(dc.errorChangeMessage("samepass"));
                        }
                        else
                        {
                            if (com.Compare2string(newpass, newpassconfirm) == true)
                            {
                                if (com.changepass(idChange, en.EncodeSHA1(newpass)) == true){
                                    if (check == true)
                                    {
                                        MessageBox.Show(dc.successChangeMessage("changeinfo"));
                                    }
                                    else
                                    {
                                        MessageBox.Show(dc.successChangeMessage("changepass"));
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(dc.successChangeMessage("else"));
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
