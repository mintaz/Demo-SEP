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

namespace Demo.GUI.Program
{
    public partial class GUI_Program_ProgramInfo : Form
    {
        public GUI_Program_ProgramInfo()
        {
            InitializeComponent();
        }
        ProgramBLL pro = new ProgramBLL();
        public string id ="";
        private void GUI_Program_ProgramInfo_Load(object sender, EventArgs e)
        {
            txtProgramName.Text = pro.LoadProgram(id).Single().name;
            txtProgramName.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string level = txtProgramLevel.Text;
            string branch = txtProgramBranch.Text;
            string type = txtProgramType.Text;
            string time = txtProgramTime.Text;
            string actor = txtProgramActor.Text;
            string vol = txtProgramVolume.Text;
            string process = txtProgramProcess.Text;
            int tc = int.Parse(txtProgramPoint.Text);
            int sem = int.Parse(txtProgramSemester.Text);
            int mark = int.Parse(txtProgramMark.Text);
            if (pro.UpdateProgram(id, level, branch, type, time, actor, vol, process, tc, sem, mark) == true)
            {

            }
        }
    }
}
