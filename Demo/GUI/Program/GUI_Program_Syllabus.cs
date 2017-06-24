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
using DevExpress.XtraEditors.Controls;

namespace Demo.GUI.Program
{
    public partial class GUI_Program_Syllabus : Form
    {
        public GUI_Program_Syllabus()
        {
            InitializeComponent();
        }
        public string idprogram = "";
        public string idsys = "";
        SyllabusBLL sys = new SyllabusBLL();
        AccountBLL account = new AccountBLL();

        void loadcomboSY()
        {
            int sem = sys.getSememster(idprogram);
            for (int i = 1; i <=sem; i++)
            {
                cboCourseSemester.Items.Add(i);
            }
            cboCourseOwner.DataSource = account.LoadAccount();
            cboCourseOwner.DisplayMember = "name";
            cboCourseOwner.ValueMember = "id";
            var list = new[]
            {
                new { Text = "Đại cương - Bắt buộc",Value =0},
                new { Text = "Đại cương - Tự chọn",Value =1},
                new {Text = "Chuyên ngành - Tự chọn",Value =2 },
                new {Text = "Chuyên ngành - Bắt buộc",Value = 3},
                new {Text = "Cơ sở ngành - Tự chọn",Value =4 },
                new { Text = "Cơ sở ngành - Bắt buộc",Value = 5},
            };
            cboCourseType.DataSource = list;
            cboCourseType.ValueMember = "Value";
            cboCourseType.DisplayMember = "Text";
            cboPreCourse.DataSource = sys.loadSyllabus(idprogram);
            cboPreCourse.DisplayMember = "name";
            cboPreCourse.ValueMember = "id";
        }

        void clean()
        {
            txtCourseCode.Text = "";
            txtCourseName.Text = "";
            txtCoursePoint.Text = "";
            txtLTtime.Text = "";
            txtTHtime.Text = "";
            
            cboCourseSemester.SelectedValue = 1;
            cboCourseType.SelectedValue = 0;
        }
        void loadpre(string line)
        {
            gcPrecourse.DataSource = sys.loadpre(line);
        }
        private void GUI_Program_Syllabus_Load(object sender, EventArgs e)
        {
            txtTHtime.ReadOnly = true;
            if (idsys == "")
            {
                loadcomboSY();
                clean();
            }
            else
            {
                txtCourseName.Text = sys.loadSys(idsys).Single().name;
                txtCourseCode.Text = sys.loadSys(idsys).Single().CourseCode;
                txtCoursePoint.Text = sys.loadSys(idsys).Single().CoursePoint.Value.ToString();
                txtLTtime.Text = sys.loadSys(idsys).Single().CourseLT.Value.ToString();
                txtTHtime.Text = ((((sys.loadSys(idsys).Single().CoursePoint.Value)*15)-(sys.loadSys(idsys).Single().CourseLT.Value)*15)).ToString();
                cboCourseOwner.SelectedValue = sys.loadSys(idsys).Single().idAccount;
                cboCourseSemester.SelectedValue = sys.loadSys(idsys).Single().CourseSemester;
                cboCourseType.SelectedValue = sys.loadSys(idsys).Single().CourseType;
                loadpre(sys.loadSys(idsys).Single().PreCourse);
                rtCourseContent.Text = sys.loadSys(idsys).Single().CourseContent;
            }
            
        }

        public string line = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string idpre = cboPreCourse.SelectedValue.ToString();
            if (idpre != null)
            {
                line = sys.AddPre(line, idpre);
                loadpre(line);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = gvPrecourse.GetRowCellValue(index, this.ID).ToString();
            line = sys.DelPre(line, id);
            loadpre(line);
        }
        int index;
        private void gvPrecourse_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void txtLTtime_TextChanged(object sender, EventArgs e)
        {
            int TC = sys.loadSys(idsys).Single().CoursePoint.Value * 15;
            int LT = sys.loadSys(idsys).Single().CourseLT.Value;
            int TH = TC - LT;
            txtTHtime.Text = TH.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtCourseName.Text;
            string code = txtCourseCode.Text;
            int TC = int.Parse(txtCoursePoint.Text);
            int LT = int.Parse(txtLTtime.Text);
            int type = int.Parse(cboCourseType.SelectedValue.ToString());
            string iac = cboCourseOwner.SelectedValue.ToString();
            int sem = int.Parse(cboCourseSemester.SelectedValue.ToString());
            string cont = rtCourseContent.Text;
            if(idsys == "")
            {
                bool add = sys.AddSysllabus(idprogram, name, code, type, iac, sem, TC, LT, line, cont);
                if(add == true)
                {
                }
                else
                {

                }
            }
            else
            {
                bool edit = sys.EditPSysllabus(idsys, name, code, type, iac, sem, TC, LT, line, cont);
                if( edit == true)
                {

                }
                else
                {

                }
            }
        }
    }
}
