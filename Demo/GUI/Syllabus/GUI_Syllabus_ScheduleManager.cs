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
    public partial class GUI_Syllabus_ScheduleManager : Form
    {
        public GUI_Syllabus_ScheduleManager()
        {
            InitializeComponent();
        }
        public string idS = "";
        public string idsche = "";
        int index;
        ScheduleBLL sche = new ScheduleBLL();
        void loadata()
        {
            gcSchedule.DataSource = sche.ListSche(idS);
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.Syllabus.GUI_Syllabus_Schedule ScheAdd = new GUI_Syllabus_Schedule();
            ScheAdd.idS = idS;
            ScheAdd.ShowDialog();
            loadata();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = gvSchedule.GetRowCellValue(index, this.ID).ToString();
            GUI.Syllabus.GUI_Syllabus_Schedule ScheEdit = new GUI_Syllabus_Schedule();
            ScheEdit.id = id;
            ScheEdit.ShowDialog();
            loadata();
        }
        DicBLL dc = new DicBLL();
        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = gvSchedule.GetRowCellValue(index, this.ID).ToString();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (sche.DelSche(id) == true)
                {
                    MessageBox.Show(dc.schedule("del"));
                }
                else
                {
                    MessageBox.Show(dc.schedule("else"));
                }
                loadata();
            }
        }

        private void GUI_Syllabus_ScheduleManager_Load(object sender, EventArgs e)
        {
            loadata();
        }

        private void gvSchedule_DoubleClick(object sender, EventArgs e)
        {
            string id = gvSchedule.GetRowCellValue(index, this.ID).ToString();
            GUI.Syllabus.GUI_Syllabus_Schedule ScheEdit = new GUI_Syllabus_Schedule();
            ScheEdit.id = id;
            ScheEdit.ShowDialog();
            loadata();

        }

        private void gvSchedule_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }
    }
}
