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
    public partial class GUI_Syllabus_Lecturer : Form
    {
        public GUI_Syllabus_Lecturer()
        {
            InitializeComponent();
        }
        public string ids = "";
        SyllabusBLL syl = new SyllabusBLL();
        EprogramDataContext db = new EprogramDataContext();
        ProgramBLL p = new ProgramBLL();
        public string idp = "";
        private void GUI_Syllabus_Lecturer_Load(object sender, EventArgs e)
        {
            if (p.getLock(idp) == true)
            {
                richtextboxsylLec.ReadOnly = true;
                fileSaveItem1.Enabled = false;
            }
            try
            {
                richtextboxsylLec.Text = db.Syllabus.Where(pro => pro.id == ids).Single().CourseLecturer;
            }
            catch
            {
                richtextboxsylLec.Text = "";
            }

        }

        private void fileSaveItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (richtextboxsylLec.Text == null)
            {
                richtextboxsylLec.Text = "";
            }
            if (syl.UpdateLect(ids, richtextboxsylLec.Text))
            {
                MessageBox.Show("Cập nhập thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi đường truyền, vui lòng thử lại sau.");
            }
        }
    }
}
