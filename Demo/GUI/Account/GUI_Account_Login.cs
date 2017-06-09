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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //demo
            string email = txtEmail.Text;
            string pass = txtPass.Text;
            if(email == "1" && pass == "1")
            {
                Main MainForm = new Main();
                MainForm.FormClosing += delegate { this.Show(); txtEmail.Text = "";txtPass.Text = ""; };
                MainForm.Show();
                this.Hide();
            }

            else if(email=="2" && pass == "2")
            {
                
                MessageBox.Show("Tài khoản của bạn hiện đang bị vô hiệu hóa, vui lòng liên hệ với Người Quản Trị để được kích hoạt.");
            }
            else
            {
                MessageBox.Show("Sai email đăng nhập hoặc mật khẩu, vui lòng kiểm tra lại");
            }
        }
    }
}
