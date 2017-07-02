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
namespace Demo.GUI.Syllabus
{
    public partial class GUI_Syllabus_MethodMapp : Form
    {
        public GUI_Syllabus_MethodMapp()
        {
            InitializeComponent();
        }
        public string idS = "";
        public string idp = "";
        int index;
        MappingBLL map = new MappingBLL();
        ProgramBLL p = new ProgramBLL();
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = gvMethodMap.GetRowCellValue(index, this.ID).ToString();
            GUI.Syllabus.GUI_Syllabus_MethodMap_Dialog mapdialog = new GUI_Syllabus_MethodMap_Dialog();
            mapdialog.idmap = id;
            mapdialog.ids = idS;
            mapdialog.idp = idp;
            mapdialog.ShowDialog();
            loadata();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Bạn không thể xóa liên kết ma trận tại đây.\nĐể xóa liên kết vui lòng xóa tại giao diện quản lý chuẩn đầu ra môn học.");
            loadata();
        }

        private void gvMethodMap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void gvMethodMap_DoubleClick(object sender, EventArgs e)
        {
            string id = gvMethodMap.GetRowCellValue(index, this.ID).ToString();
            GUI.Syllabus.GUI_Syllabus_MethodMap_Dialog mapdialog = new GUI_Syllabus_MethodMap_Dialog();
            mapdialog.idmap = id;
            mapdialog.ids = idS;
            mapdialog.ShowDialog();
            loadata();
        }
        void loadata()
        {
            gcMethodMap.DataSource = map.listmap(idS);
        }
        private void GUI_Syllabus_MethodMapp_Load(object sender, EventArgs e)
        {
            loadata();
            if (p.getLock(idp) == true)
            {
                btnDel.Enabled = false;
            }
        }
    }
}
