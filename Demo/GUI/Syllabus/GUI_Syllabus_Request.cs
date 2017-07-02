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
    public partial class GUI_Syllabus_Request : Form
    {
        public GUI_Syllabus_Request()
        {
            InitializeComponent();
        }
        public string ids = "";
        EprogramDataContext db = new EprogramDataContext();
        SyllabusBLL syl = new SyllabusBLL();
        public string idp = "";
        ProgramBLL p = new ProgramBLL();
        private void GUI_Syllabus_Request_Load(object sender, EventArgs e)
        {
            if (p.getLock(idp) == true)
            {
                richtextboxrequest.ReadOnly = true;
                fileSaveItem1.Enabled = false;
            }
            try
            {
                richtextboxrequest.Text = db.Syllabus.Where(pro => pro.id == ids).Single().CourseRequest;
            }
            catch
            {
                richtextboxrequest.Text = "";
            }

        }

        private void fileSaveItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (richtextboxrequest.Text == null)
            {
                richtextboxrequest.Text = "";
            }
            if (syl.UpdateRequest(ids, richtextboxrequest.Text))
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
