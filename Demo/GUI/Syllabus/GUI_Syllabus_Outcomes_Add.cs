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
namespace Demo.GUI.Syllabus
{
    public partial class GUI_Syllabus_Outcomes_Add : Form
    {
        public GUI_Syllabus_Outcomes_Add()
        {
            InitializeComponent();
        }
        public string idS = "";
        public string idSout = "";
        SyllabusOutBLL syou = new SyllabusOutBLL();
        DicBLL dc = new DicBLL();
        MappingBLL map = new MappingBLL();
        private void GUI_Syllabus_Outcomes_Add_Load(object sender, EventArgs e)
        {
            if (idSout != "")
            {
                txtOutNo.Text = syou.loadout(idSout).Single().OutcomeNo;
                rtCourseOut.Text = syou.loadout(idSout).Single().OutcomeContent;
            }
            else
            {
                rtCourseOut.Text = "";
                txtOutNo.Text = "";
            }
        }
        string temp;

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isempty = false;

            if (rtCourseOut.Text == null || rtCourseOut.Text == "")
            {
                temp = temp + dc.sysllabusout("missingcontent") + "\n";
                isempty = true;
            }
            if (txtOutNo.Text == null || txtOutNo.Text == "")
            {
                temp = temp + dc.sysllabusout("missingno") + "\n";
                isempty = true;
            }
            string content = rtCourseOut.Text;
            string no = txtOutNo.Text;
            if (isempty == false)
            {
                if (idSout == "")
                {
                    if (syou.AddOut(idS,no, content) == true)
                    {

                        MessageBox.Show(dc.sysllabusout("success"));
                        rtCourseOut.Text = "";
                        txtOutNo.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(dc.sysllabusout("else"));
                    }
                }
                else
                {
                    if (syou.EditOut(idSout,no, content) == true)
                    {
                        MessageBox.Show(dc.sysllabusout("edit"));
                    }
                    else
                    {
                        MessageBox.Show(dc.sysllabusout("else"));
                    }
                }
            }
            else
            {
                MessageBox.Show(temp + "\nVui lòng kiểm tra lại");
            }
        }
    }
}
