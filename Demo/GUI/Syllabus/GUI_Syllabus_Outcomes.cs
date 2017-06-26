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
    public partial class GUI_Syllabus_Outcomes : Form
    {
        public GUI_Syllabus_Outcomes()
        {
            InitializeComponent();
        }
        int index;
        public string idsys = "";
        SyllabusOutBLL syou = new SyllabusOutBLL();
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.Syllabus.GUI_Syllabus_Outcomes_Add outadd = new GUI_Syllabus_Outcomes_Add();
            outadd.idS = idsys;
            outadd.ShowDialog();
            loadData();
        }
        void loadData()
        {
            gcCourseOut.DataSource = syou.loadlistout(idsys);
        }
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idso = gvCourseOut.GetRowCellValue(index, this.ID).ToString();
            GUI.Syllabus.GUI_Syllabus_Outcomes_Add outedit = new GUI_Syllabus_Outcomes_Add();
            outedit.idSout = idso;
            outedit.ShowDialog();
            loadData();
        }
        DicBLL dc = new DicBLL();
        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idso = gvCourseOut.GetRowCellValue(index, this.ID).ToString();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (syou.DelOut(idso) == true)
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

        private void gvCourseOut_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gvCourseOut_DoubleClick(object sender, EventArgs e)
        {
            string idso = gvCourseOut.GetRowCellValue(index, this.ID).ToString();
            GUI.Syllabus.GUI_Syllabus_Outcomes_Add outedit = new GUI_Syllabus_Outcomes_Add();
            outedit.idSout = idso;
            outedit.ShowDialog();
            loadData();
        }

        private void GUI_Syllabus_Outcomes_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
