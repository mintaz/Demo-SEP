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
namespace Demo.GUI.Syllabus
{
    public partial class GUI_Syllabus_OtherInfo : Form
    {
        public GUI_Syllabus_OtherInfo()
        {
            InitializeComponent();
        }
        public string ids = "";
        EprogramDataContext db = new EprogramDataContext();
        public string idp = "";
        ProgramBLL p = new ProgramBLL();
        private void GUI_Syllabus_OtherInfo_Load(object sender, EventArgs e)
        {
            if (p.getLock(idp) == true)
            {
                richTextBox1.ReadOnly = true;
                richTextBox2.ReadOnly = true;
                richTextBox3.ReadOnly = true;
                richTextBox4.ReadOnly = true;
                richTextBox5.ReadOnly = true;
                button1.Enabled = false;
            }
            try
            {
                richTextBox1.Text = db.Syllabus.Where(pro => pro.id == ids).Single().CourseLecturer;
                richTextBox2.Text = db.Syllabus.Where(pro => pro.id == ids).Single().CourseDescription;
                richTextBox3.Text = db.Syllabus.Where(pro => pro.id == ids).Single().CourseRequest;
                richTextBox4.Text = db.Syllabus.Where(pro => pro.id == ids).Single().CourseDocument;
                richTextBox5.Text = db.Syllabus.Where(pro => pro.id == ids).Single().CourseMethod;
            }
            catch
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                richTextBox3.Text = "";
                richTextBox4.Text = "";
                richTextBox5.Text = "";
            }

        }
        SyllabusBLL syl = new SyllabusBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == null)
            {
                richTextBox1.Text = "";
            }
            if (richTextBox2.Text == null)
            {
                richTextBox2.Text = "";
            }
            if (richTextBox3.Text == null)
            {
                richTextBox3.Text = "";
            }
            if (richTextBox4.Text == null)
            {
                richTextBox4.Text = "";
            }
            if (richTextBox5.Text == null)
            {
                richTextBox5.Text = "";
            }
            if ((syl.UpdateDocument(ids, richTextBox4.Text) && syl.UpdateDes(ids,richTextBox2.Text) && syl.UpdateLect(ids,richTextBox1.Text) && syl.UpdateRequest(ids,richTextBox3.Text) && syl.UpdateMethods(ids,richTextBox5.Text))==true)
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
