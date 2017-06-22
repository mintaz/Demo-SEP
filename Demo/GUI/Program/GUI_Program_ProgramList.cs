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
    public partial class GUI_Program_ProgramList : Form
    {
        public string Idaccount = "";
        public bool admin;
        public GUI_Program_ProgramList()
        {
            InitializeComponent();
        }
        EprogramDataContext db = new EprogramDataContext();
        LoginBLL ac = new LoginBLL();
        private void GUI_Program_ProgramList_Load(object sender, EventArgs e)
        {
            var info = (from c in db.Programs
                        where c.idAccount == Idaccount
                        select new
                        {
                             c.id,
                            c.name
                        }).Union(from c in db.Syllabus
                                 where c.idAccount == Idaccount
                                 select new
                                 {
                                     c.id,
                                     c.name
                                 });
            gcProgramList.DataSource = info.ToList();
        }
        int index;
        private void gvProgramList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }
        string id;
        string idsub;
        private void gvProgramList_DoubleClick(object sender, EventArgs e)
        {
            id = gvProgramList.GetRowCellValue(index, this.ID).ToString();
            idsub = id.Substring(0, 2);

            Main mainform = new Main();
            if (idsub == "PR")
            {
                mainform.auth = 1;
                mainform.name = ac.getnameprogram(id);
            }
            else if ( idsub == "SY")
            {
                mainform.auth = 2;
                mainform.name = ac.getnamesyllabus(id);
            }
            else
            {
                mainform.auth = 0;
            }
            mainform.idpath = this.id;
            mainform.Show();
            this.Hide();

        }
    }
}
