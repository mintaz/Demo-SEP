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
using System.Collections.Generic;
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

        private void GUI_Program_Syllabus_Load(object sender, EventArgs e)
        {
            if (idsys == "")
            {
                loadcomboSY();
                clean();
            }
            else
            {

            }
            
        }
    }
}
