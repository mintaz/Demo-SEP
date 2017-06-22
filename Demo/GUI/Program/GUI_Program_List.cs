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
namespace Demo.GUI.Program
{
    public partial class GUI_Program_List : Form
    {
        public GUI_Program_List()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            ProgramBLL pr = new ProgramBLL();
            gcProgramList.DataSource = pr.Load();
        }
        private void GUI_Program_List_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.GUI_Program_CreateProgram crp = new GUI_Program_CreateProgram();
            crp.ShowDialog();
            loadData();
        }
        int index;
        private void gvProgramList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = gvProgramList.GetRowCellValue(index, this.ID).ToString();

        }
    }
}
