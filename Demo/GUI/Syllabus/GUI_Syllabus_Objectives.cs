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
        SyllabusObjBLL sysobj = new SyllabusObjBLL();
        private void gvCourseObj_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void GUI_Syllabus_Objectives_Load(object sender, EventArgs e)
        {
            gcCourseObj.DataSource = sysobj.loadlistobj(idsys);
        }

        private void gvCourseObj_DoubleClick(object sender, EventArgs e)
        {
            string idso = gvCourseObj.GetRowCellValue(index, this.ID).ToString();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
