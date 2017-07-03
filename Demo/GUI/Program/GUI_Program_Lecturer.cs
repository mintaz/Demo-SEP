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
    public partial class GUI_Program_Lecturer : Form
    {
        public GUI_Program_Lecturer()
        {
            InitializeComponent();
        }
        public string idprogram = "";
        EprogramDataContext db = new EprogramDataContext();
        ProgramBLL p = new ProgramBLL();
        private void GUI_Program_PackageInfo_Load(object sender, EventArgs e)
        {
            if (p.getLock(idprogram) == true)
            {
                richtextboxLecturer.ReadOnly = true;
                fileSaveItem1.Enabled = false;
            }
            try
            {
                richtextboxLecturer.Text = db.Programs.Where(pro => pro.id == idprogram).Single().ProgramLecturer;
            }
            catch
            {
                richtextboxLecturer.Text = "";
            }
           richtextboxLecturer.Options.Behavior.SaveAs = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            richtextboxLecturer.Options.Behavior.Save = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
        }

        private void fileSaveItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (richtextboxLecturer.Text == null)
            {
                richtextboxLecturer.Text = "";
            }
            if (p.Updatelecturer(idprogram, richtextboxLecturer.Text))
            {
                MessageBox.Show("Cập nhập thành công.");
                Hide();
            }
            else
            {
                MessageBox.Show("Lỗi đường truyền, vui lòng thử lại sau.");
            }
        }
    }
}
