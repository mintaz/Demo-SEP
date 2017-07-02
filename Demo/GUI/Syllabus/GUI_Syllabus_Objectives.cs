using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
namespace Demo.GUI.Syllabus
{
    public partial class GUI_Syllabus_Objectives : Form
    {
        public GUI_Syllabus_Objectives()
        {
            InitializeComponent();
        }
        int index;
        public string idsys = "";
        public string idp = "";
        SyllabusObjBLL sysobj = new SyllabusObjBLL();
        ProgramBLL p = new ProgramBLL();
        private void gvCourseObj_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        void loadData()
        {
            gcCourseObj.DataSource = sysobj.loadlistobj(idsys);
            if (p.getLock(idp) == true)
            {
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
            }
        }
        private void GUI_Syllabus_Objectives_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gvCourseObj_DoubleClick(object sender, EventArgs e)
        {
            string idso = gvCourseObj.GetRowCellValue(index, this.ID).ToString();
            GUI.Syllabus.GUI_Syllabus_Objectives_Add objedit = new GUI_Syllabus_Objectives_Add();
            objedit.idobj = idso;
            objedit.ShowDialog();
            loadData();
            
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.Syllabus.GUI_Syllabus_Objectives_Add objadd = new GUI_Syllabus_Objectives_Add();
            objadd.ids = idsys ;
            objadd.ShowDialog();
            loadData();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idso = gvCourseObj.GetRowCellValue(index, this.ID).ToString();
            GUI.Syllabus.GUI_Syllabus_Objectives_Add objedit = new GUI_Syllabus_Objectives_Add();
            objedit.idobj = idso;
            objedit.idp = idp;
            objedit.ShowDialog();
            loadData();
        }
        DicBLL dc = new DicBLL();
        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idso = gvCourseObj.GetRowCellValue(index, this.ID).ToString();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (sysobj.DelObj(idso) == true)
                {
                    MessageBox.Show(dc.sysllabusobj("del"));
                }
                else
                {
                    MessageBox.Show(dc.sysllabusobj("else"));
                }
                loadData();
            }
        }
    }
}
