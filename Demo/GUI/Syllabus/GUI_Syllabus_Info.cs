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
    public partial class GUI_Syllabus_Info : Form
    {
        public GUI_Syllabus_Info()
        {
            InitializeComponent();
        }
        public string idsysinfo = "";
        SyllabusBLL sys = new SyllabusBLL();
        DicBLL dc = new DicBLL();
        ProgramBLL p = new ProgramBLL();
        public string idp = "";
        private void GUI_Syllabus_Info_Load(object sender, EventArgs e)
        {
            txtCoursePoint.ReadOnly = true;
            if (p.getLock(idp) == true)
            {
                txtCourseLevel.ReadOnly = true;
                txtCoursePoint.ReadOnly = true;
                btnSave.Enabled = false;
            }
            string point, level, time;
            try
            {
                time = sys.loadSys(idsysinfo).Single().CourseTime;
            }
            catch
            {
                time = "";
            }
            try
            {
                level = sys.loadSys(idsysinfo).Single().CourseLevel;
            }
            catch
            {
                level = "";
            }
            try
            {
                point = sys.loadSys(idsysinfo).Single().CoursePoint.ToString();
            }
            catch
            {
                point = "";
            }
            txtCoursePoint.Text = point;
            txtCourseLevel.Text = level;
            rtCourseTime.Text = time;
        }
        string temp;
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isempty = false;
            string levevlup = txtCourseLevel.Text;
            string timeup = rtCourseTime.Text;
            if(txtCourseLevel.Text == null || txtCourseLevel.Text == "")
            {
                isempty = true;
                temp = temp + dc.syllabusinfo("level") + "\n";

            }
            if(rtCourseTime.Text == null || rtCourseTime.Text == "")
            {
                isempty = true;
                temp = temp + dc.syllabusinfo("time") + "\n";
            }
            if(isempty == false)
            {
                if (sys.UpdateSysInfo(idsysinfo, levevlup, timeup) == true)
                {
                    MessageBox.Show(dc.syllabusinfo("success"));
                    this.Close();
                }
                else
                {
                    MessageBox.Show(dc.syllabusinfo("else"));
                }
            }
            else
            {
                MessageBox.Show(temp + "\nVui lòng kiểm tra lại");
            }
        }
    }
}
