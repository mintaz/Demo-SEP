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
        ProgramBLL pro = new ProgramBLL();
        DicBLL dc = new DicBLL();

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
                if (pro.getLock(idprogram) == false)
                {
                    txtCourseCode.ReadOnly = true;
                    txtCourseName.ReadOnly = true;
                    txtCoursePoint.ReadOnly = true;
                    txtLTtime.ReadOnly = true;
                    txtTHtime.ReadOnly = true;
                    btnSave.Enabled = false;
                    btnAdd.Enabled = false;
                    btnDel.Enabled = false;
                    rtCourseContent.ReadOnly = true;
                }
                {
                    
                    loadcomboSY();
                    txtCourseName.Text = sys.loadSys(idsys).Single().name;
                    txtCourseCode.Text = sys.loadSys(idsys).Single().CourseCode;
                    txtCoursePoint.Text = sys.loadSys(idsys).Single().CoursePoint.ToString();
                    txtLTtime.Text = sys.loadSys(idsys).Single().CourseLT.ToString();
                    string time = "";
                    try
                    {
                        int point = (sys.loadSys(idsys).Single().CoursePoint.Value) * 15;
                        int LT = (sys.loadSys(idsys).Single().CourseLT.Value) * 15;
                        time = (point - LT).ToString();
                    }
                    catch
                    {
                        time = "";
                    }
                    txtTHtime.Text = time;
                    cboCourseOwner.SelectedValue = sys.loadSys(idsys).Single().idAccount;
                    cboCourseSemester.SelectedItem = int.Parse((sys.loadSys(idsys).Single().CourseSemester).ToString());
                    cboCourseType.SelectedValue = sys.loadSys(idsys).Single().CourseType;
                    loadpre(sys.loadSys(idsys).Single().PreCourse);
                    rtCourseContent.Text = sys.loadSys(idsys).Single().CourseContent;
                }
            }
            
        }

        public string line = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string idpre = cboPreCourse.SelectedValue.ToString();
                line = sys.AddPre(line, idpre);
                loadpre(line);
            }
            catch
            {

            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string id = gvPrecourse.GetRowCellValue(index, this.ID).ToString();
                line = sys.DelPre(line, id);
                loadpre(line);
            }
            catch
            {

            }
        }
        int index;
        private void gvPrecourse_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void txtLTtime_TextChanged(object sender, EventArgs e)
        {
            int TC, LT, TH;
            try
            {
                TC = int.Parse(txtCoursePoint.Text);
            }
            catch
            {
                TC = 0;
            }
            try
            {
                LT = int.Parse(txtLTtime.Text);
            }
            catch
            {
                LT = TC*15;
            }
            if (LT <= (TC * 15))
            {
                TH = TC * 15 - LT;
            }else
            {
                TH = 0;
            }
            txtTHtime.Text = TH.ToString();
        }
        string temp;
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isempty = false;           
            string name = txtCourseName.Text;
            string code = txtCourseCode.Text;
            int TC = int.Parse(txtCoursePoint.Text);
            int LT = int.Parse(txtLTtime.Text);
            int type = int.Parse(cboCourseType.SelectedValue.ToString());
            string iac = cboCourseOwner.SelectedValue.ToString();
            int sem = int.Parse(cboCourseSemester.Text);
            string cont = rtCourseContent.Text;
            if(name == null || name == "")
            {
                isempty = true;
                temp = temp + dc.successcreatsyllabus("name") +"\n";
            }
            if( code == null || code == "" )
            {
                isempty = true;
                if (sys.checkexist(code) == true)
                {
                    temp = temp + dc.successcreatsyllabus("exist") + "\n";
                }
                else
                {
                    temp = temp + dc.successcreatsyllabus("code") + "\n";
                }
            }
            if (txtCoursePoint.Text == null || txtCoursePoint.Text == "")
            {
                isempty = true;
                temp = temp+ dc.successcreatsyllabus("TC") +"\n";
            }
            if( txtLTtime.Text == null || txtLTtime.Text == "")
            {
                isempty = true;
                temp = temp + dc.successcreatsyllabus("LT") + "\n";
            }
            if(cont == null || cont == "")
            {
                isempty = true;
                temp = temp + dc.successcreatsyllabus("content") + "\n";
            }
            if (isempty == false)
            {
                if (idsys == "")
                {
                    bool add = sys.AddSysllabus(idprogram, name, code, type, iac, sem, TC, LT, line, cont);
                    if (add == true)
                    {
                        MessageBox.Show(dc.successcreatsyllabus("success"));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(dc.successcreatsyllabus("else"));
                    }
                }
                else
                {
                    bool edit = sys.EditPSysllabus(idsys, name, code, type, iac, sem, TC, LT, line, cont);
                    if (edit == true)
                    {
                        MessageBox.Show(dc.successcreatsyllabus("edit"));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(dc.successcreatsyllabus("else"));
                    }
                }
            }
            else
            {
                MessageBox.Show(temp + "\nVui lòng kiểm tra lại");
            }
        }

        private void txtCoursePoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLTtime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
