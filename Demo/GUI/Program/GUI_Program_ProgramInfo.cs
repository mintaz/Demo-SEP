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
        DicBLL dc = new DicBLL();
        string temp;
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
            
            bool isempty = false;
            if(level == "")
            {
                temp = temp+dc.successupdateprogram("level")+"\n";
                isempty = true;
            }
            if (branch == "")
            {
                temp = temp + dc.successupdateprogram("branch") + "\n";
                isempty = true;
            }
            if (type == "")
            {
                temp = temp + dc.successupdateprogram("type") + "\n";
                isempty = true;
            }
            if (time == "")
            {
                temp = temp + dc.successupdateprogram("time") + "\n";
                isempty = true;
            }
            if (actor == "")
            {
                temp = temp + dc.successupdateprogram("actor") + "\n";
                isempty = true;
            }
            if (vol == "")
            {
                temp = temp + dc.successupdateprogram("vol") + "\n";
                isempty = true;
            }
            if (process == "")
            {
                temp = temp + dc.successupdateprogram("process") + "\n";
                isempty = true;
            }
            if (sem == 0)
            {
                temp = temp + dc.successupdateprogram("sem") + "\n";
                isempty = true;
            }
            if (tc == 0)
            {
                temp = temp + dc.successupdateprogram("tc") + "\n";
                isempty = true;
            }
            if (mark == 0)
            {
                temp = temp + dc.successupdateprogram("10") + "\n";
                isempty = true;
            }
            if (isempty == false)
            {
                if (pro.UpdateProgram(id, level, branch, type, time, actor, vol, process, tc, sem, mark) == true)
                {
                    MessageBox.Show(dc.successupdateprogram("success"));
                }
                else
                {
                    MessageBox.Show(dc.successupdateprogram("else"));
                }
            
            }
            else
            {
                MessageBox.Show(temp + "\nVui lòng kiểm tra lại");
            }
        }
    }
}
