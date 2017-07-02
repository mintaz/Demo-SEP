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
    public partial class GUI_Syllabus_Document : Form
    {
        public GUI_Syllabus_Document()
        {
            InitializeComponent();
        }
        public string idsyllabus = "";
        public string idp = "";
        EprogramDataContext db = new EprogramDataContext();
        ProgramBLL p = new ProgramBLL();
        private void GUI_Syllabus_Document_Load(object sender, EventArgs e)
        {
            if (p.getLock(idp) == true)
            {
                richtextboxDocument.ReadOnly = true;
                fileSaveItem1.Enabled = false;
            }
            try
            {
                richtextboxDocument.Text = db.Syllabus.Where(pro => pro.id == idsyllabus).Single().CourseDocument;
            }
            catch
            {
                richtextboxDocument.Text = "";
            }

        }

        SyllabusBLL syl = new SyllabusBLL();
        private void fileSaveItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (richtextboxDocument.Text == null)
            {
                richtextboxDocument.Text = "";
            }
            if (syl.UpdateDocument(idsyllabus, richtextboxDocument.Text))
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
