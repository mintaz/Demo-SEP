using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Demo.GUI
{
    public partial class GUI_Account_Login : Form
    {
        public GUI_Account_Login()
        {
            InitializeComponent();
        }
        public bool admin;
        public string idAccountlogin;

        public void loginaction()
        {
            EncryptBLL encrypt = new EncryptBLL();
            LoginBLL lg = new LoginBLL();
            DicBLL dic = new DicBLL();
            string user = txtEmail.Text;
            string pass = encrypt.EncodeSHA1(txtPass.Text);

            if (lg.isvaildEmail(user) == true)
            {
                if (lg.isvaildAccount(user) == true)
                {
                    if (lg.isvaildPass(user, pass) == true)
                    {
                        if (lg.isActive(user) == true)
                        {
                            if (lg.isAdmin(user) == true)
                            {
                                admin = true;
                            }
                            else
                            {
                                admin = false;
                            }
                            idAccountlogin = lg.getID(user);
                            if (lg.isCount(idAccountlogin) == true)
                            {
                                GUI.GUI_Program_ProgramList formlist = new GUI_Program_ProgramList();
                                formlist.Idaccount = idAccountlogin;
                                formlist.admin = admin;
                                formlist.FormClosing += delegate { this.Show(); };
                                //formlist.Formclosing += delegate{(this.Show(); };
                                formlist.Show();
                                this.Hide();
                            }
                            else
                            {
                                Main mainform = new Main();
                                mainform.auth = 0;
                                mainform.idaccountmain = idAccountlogin;
                                mainform.admin = admin;
                                mainform.FormClosing += delegate { this.Show(); };
                                mainform.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show(dic.errorloginMessage("chua acitve"));
                        }
                    }
                    else
                    {
                        MessageBox.Show(dic.errorloginMessage("sai pass"));
                    }
                }
                else
                {
                    MessageBox.Show(dic.errorloginMessage("sai user"));
                }
            }
            else
            {
                MessageBox.Show(dic.errorloginMessage("sai email"));
            }
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            loginaction();


        }

        private void GUI_Account_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                loginaction();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginaction();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginaction();
            }
        }
    }
}
