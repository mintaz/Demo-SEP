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
    public partial class GUI_Program_CreateSyllabus : Form
    {
        public GUI_Program_CreateSyllabus()
        {
            InitializeComponent();
        }
        SyllabusBLL s = new SyllabusBLL();
        public string idPrg = "";
        public void loadData()
        {

            gcCourse.DataSource = s.loadSyllabus(idPrg);
        }
        private void GUI_Program_CreateSyllabus_Load(object sender, EventArgs e)
        {
            loadData();
            if (p.getLock(idPrg)==true)
            {
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
            }

        }
        ProgramBLL p = new ProgramBLL();
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            GUI.Program.GUI_Program_Syllabus sysadd = new GUI_Program_Syllabus();
            sysadd.idprogram = idPrg;
            sysadd.ShowDialog();
            loadData();

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = gvCourse.GetRowCellValue(index, this.ID).ToString();
            GUI.Program.GUI_Program_Syllabus sysedit = new GUI_Program_Syllabus();
            sysedit.idprogram = idPrg;
            sysedit.idsys = id;
            sysedit.ShowDialog();
            loadData();
        }
        int index;
        private void gvCourse_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gvCourse_DoubleClick(object sender, EventArgs e)
        {
            string id = gvCourse.GetRowCellValue(index, this.ID).ToString();
            GUI.Program.GUI_Program_Syllabus sysedit = new GUI_Program_Syllabus();
            sysedit.idprogram = idPrg;
            sysedit.idsys = id;
            sysedit.ShowDialog();
            loadData();
        }
        EprogramDataContext db = new EprogramDataContext();
        DicBLL dc = new DicBLL();
        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = gvCourse.GetRowCellValue(index, this.ID).ToString();

            if (db.Syllabus.Where(s => s.id == id).Single().isLockEdit == true)
            {
                MessageBox.Show("Bạn không thể xóa môn học.");
            }
            else
            {

                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (s.delSy(id) == true)
                    {
                        MessageBox.Show("Xóa Thành Công.");
                    }
                    else
                    {
                        MessageBox.Show(dc.errorAccountMessage("else"));
                    }
                    loadData();
                }
            }

        }
    }
}
