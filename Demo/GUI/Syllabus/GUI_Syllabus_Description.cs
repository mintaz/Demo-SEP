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
    public partial class GUI_Syllabus_Description : Form
    {
        public GUI_Syllabus_Description()
        {
            InitializeComponent();
        }
        public string ids = "";
        EprogramDataContext db = new EprogramDataContext();
        public string  idp = "";
        ProgramBLL p = new ProgramBLL();
        private void GUI_Syllabus_Description_Load(object sender, EventArgs e)
        {
            if (p.getLock(idp) == true)
            {
                richtextboxDes.ReadOnly = true;
                fileSaveItem1.Enabled = false;
            }
            try
            {
                richtextboxDes.Text = db.Syllabus.Where(pro => pro.id == ids).Single().CourseDescription;
            }
            catch
            {
                richtextboxDes.Text = "";
            }

        }
        SyllabusBLL syl = new SyllabusBLL();
        private void fileSaveItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (richtextboxDes.Text == null)
            {
                richtextboxDes.Text = "";
            }
            if (syl.UpdateDes(ids, richtextboxDes.Text))
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
