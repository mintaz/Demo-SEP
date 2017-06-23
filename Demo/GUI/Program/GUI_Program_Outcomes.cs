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
    public partial class GUI_Program_Outcomes : Form
    {
        public GUI_Program_Outcomes()
        {
            InitializeComponent();
        }
        public string idprogram = "";
        public string idprogramout = "";
        ProgramOutBLL pro = new ProgramOutBLL();
        void loadData()
        {
            gcProgramOut.DataSource = pro.LoadPOutcomes(idprogram);
        }
        private void GUI_Program_Outcomes_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gcProgramOut_DoubleClick(object sender, EventArgs e)
        {
            idprogramout = gvProgramOut.GetRowCellValue(index, this.ID).ToString();
            if (idprogramout != "")
            {
                GUI.GUI_Program_Outcomes_AddEdit editform = new GUI_Program_Outcomes_AddEdit();
                editform.idprout = idprogramout;
                editform.ShowDialog();
            }
            loadData();
        }
        int index;
        private void gvProgramOut_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.GUI_Program_Outcomes_AddEdit addform = new GUI_Program_Outcomes_AddEdit();
            addform.ShowDialog();
            loadData();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            idprogramout =gvProgramOut.GetRowCellValue(index, this.ID).ToString();
            if (idprogramout != "")
            {
                GUI.GUI_Program_Outcomes_AddEdit editform = new GUI_Program_Outcomes_AddEdit();
                editform.idprout = idprogramout;
                editform.ShowDialog();
            }
            loadData();
        }
    }
}
