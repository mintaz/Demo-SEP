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
    public partial class GUI_Program_OtherInfo : Form
    {
        public GUI_Program_OtherInfo()
        {
            InitializeComponent();
        }
        public string idprogram = "";
        EprogramDataContext db = new EprogramDataContext();
        ProgramBLL p = new ProgramBLL();
        private void GUI_Program_OtherInfo_Load(object sender, EventArgs e)
        {
            if (p.getLock(idprogram) == true)
            {
                richTextBox1.ReadOnly = true;
                richTextBox2.ReadOnly = true;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            try
            {
                richTextBox1.Text = db.Programs.Where(pro => pro.id == idprogram).Single().ProgramLecturer;
                richTextBox1.Text = db.Programs.Where(pro => pro.id == idprogram).Single().ProgramPackage;
            }
            catch
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == null)
            {
                richTextBox1.Text = "";
            }
            if (p.Updatelecturer(idprogram, richTextBox1.Text))
            {
                MessageBox.Show("Cập nhập thành công.");
            }
            else
            {
                MessageBox.Show("Lỗi đường truyền, vui lòng thử lại sau.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == null)
            {
                richTextBox2.Text = "";
            }
            if (p.UpdatePackage(idprogram, richTextBox2.Text))
            {
                MessageBox.Show("Cập nhập thành công.");
            }
            else
            {
                MessageBox.Show("Lỗi đường truyền, vui lòng thử lại sau.");
            }
        }
    }
}
