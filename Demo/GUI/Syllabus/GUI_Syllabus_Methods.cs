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
    public partial class GUI_Syllabus_Methods : Form
    {
        public GUI_Syllabus_Methods()
        {
            InitializeComponent();
        }
        EprogramDataContext db = new EprogramDataContext();
        public string ids = "";
        private void GUI_Syllabus_Methods_Load(object sender, EventArgs e)
        {
            try
            {
                richtextboxMethods.Text = db.Syllabus.Where(pro => pro.id == ids).Single().CourseMethod;
            }
            catch
            {
                richtextboxMethods.Text = "";
            }

        }
        SyllabusBLL syl = new SyllabusBLL();
        private void fileSaveItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (richtextboxMethods.Text == null)
            {
                richtextboxMethods.Text = "";
            }
            if (syl.UpdateMethods(ids, richtextboxMethods.Text))
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
