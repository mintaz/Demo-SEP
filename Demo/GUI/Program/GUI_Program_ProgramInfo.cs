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
            if(pro.LoadProgram(id).Single().ProgramActor != null || pro.LoadProgram(id).Single().ProgramActor != "")
            {
                txtProgramActor.Text = pro.LoadProgram(id).Single().ProgramActor;
            }
            if(pro.LoadProgram(id).Single().ProgramBranch != null || pro.LoadProgram(id).Single().ProgramBranch != "")
            {
                txtProgramBranch.Text = pro.LoadProgram(id).Single().ProgramBranch;
            }
            if( pro.LoadProgram(id).Single().ProgramLevel != null || pro.LoadProgram(id).Single().ProgramLevel != "")
            {
                txtProgramLevel.Text = pro.LoadProgram(id).Single().ProgramLevel;
            }
            if(pro.LoadProgram(id).Single().ProgramVolume != null || pro.LoadProgram(id).Single().ProgramVolume != "")
            {
                txtProgramVolume.Text = pro.LoadProgram(id).Single().ProgramVolume;
            }
            if(pro.LoadProgram(id).Single().ProgramType != null || pro.LoadProgram(id).Single().ProgramType != "")
            {
                txtProgramType.Text = pro.LoadProgram(id).Single().ProgramType;
            }
            if(pro.LoadProgram(id).Single().ProgramTime != null || pro.LoadProgram(id).Single().ProgramTime != "")
            {
                txtProgramTime.Text = pro.LoadProgram(id).Single().ProgramTime;
            }
            if(pro.LoadProgram(id).Single().ProgramProcess != null || pro.LoadProgram(id).Single().ProgramProcess != "")
            {
                txtProgramProcess.Text = pro.LoadProgram(id).Single().ProgramProcess;
            }
            if (pro.LoadProgram(id).Single().ProgramSemester != null || pro.LoadProgram(id).Single().ProgramSemester.ToString() != "")
            {
                txtProgramSemester.Text = pro.LoadProgram(id).Single().ProgramSemester.ToString();
            }
            if (pro.LoadProgram(id).Single().ProgramPoint != null || pro.LoadProgram(id).Single().ProgramPoint.ToString() != "")
            {
                txtProgramMark.Text = pro.LoadProgram(id).Single().ProgramPoint.ToString() ;
            }
            if (pro.LoadProgram(id).Single().ProgramTC != null || pro.LoadProgram(id).Single().ProgramTC.ToString() != "")
            {
                txtProgramPoint.Text = pro.LoadProgram(id).Single().ProgramTC.ToString();
            }
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

        private void txtProgramMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtProgramSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtProgramPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
