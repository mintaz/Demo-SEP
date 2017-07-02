using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Demo.GUI
{
    public partial class GUI_Account_Manager_AddEdit : Form
    {
        public string idAc = "";
        public GUI_Account_Manager_AddEdit()
        {
            InitializeComponent();

        }

        AccountBLL at = new AccountBLL();

        public void clear()
        {
            txtAccountManagerEmail.Text = "";
            txtname.Text = "";
        }
        private void GUI_Account_Manager_AddEdit_Load(object sender, EventArgs e)
        {
            var admin = new[]
            {
                new { Text = "Admin",Value =1},
                new { Text = "Tài khoản thường",Value =0}
            };
            cboAccountManagerType.DataSource = admin;
            cboAccountManagerType.DisplayMember = "Text";
            cboAccountManagerType.ValueMember = "Value";
            if (idAc == "") //check add or edit
            {
                checkboxActive.AutoCheck = true;
                cboAccountManagerType.SelectedValue = 0;
                clear();
                
            }
            else
            {
                //load user info
                txtAccountManagerEmail.Text = at.LoadUser(idAc).Single().email;
                txtname.Text = at.LoadUser(idAc).Single().name;
                if(at.LoadUser(idAc).Single().isAdmin == true)
                {
                    cboAccountManagerType.SelectedValue = 1;
                }
                else
                {
                    cboAccountManagerType.SelectedValue = 0;
                }
                if (at.LoadUser(idAc).Single().Active == true)
                {
                    checkboxActive.Checked = true;
                }
                else
                {
                    checkboxActive.Checked = false;
                }

            }
            
            
        }

        private void btnAccountManagerSave_Click(object sender, EventArgs e)
        {
            LoginBLL lg = new LoginBLL();
            DicBLL dic = new DicBLL();
            string email = txtAccountManagerEmail.Text;
            string name = txtname.Text;
            int auth = int.Parse(cboAccountManagerType.SelectedValue.ToString());
            bool ad = false;
            bool active = false;
            if(checkboxActive.Checked == true)
            {
                active = true;
            }
            if(auth == 1)
            {
                ad = true;
            }
            
            if(idAc == "")
            {
                if (lg.isvaildEmail(email) == true)
                {
                    if(at.AddAccount(email, name, ad, active) == true)
                    {
                        MessageBox.Show(dic.successAccountMessage("add"));
                        clear();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(dic.errorAccountMessage("else"));
                    }
                }
                else
                {
                    MessageBox.Show(dic.errorAccountMessage("sai email"));

                }
            }
            else
            {
                if (lg.isvaildEmail(email) == true)
                {
                    if (at.EditAccount(idAc, email, name, ad, active) == true)
                    {
                        MessageBox.Show(dic.successAccountMessage("edit"));
                        clear();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(dic.errorAccountMessage("else"));
                    }
                }
                else
                {
                    MessageBox.Show(dic.errorAccountMessage("sai email"));

                }
            }



        }
    }
}
