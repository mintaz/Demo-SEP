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
    public partial class GUI_Syllabus_Objectives_Add: Form
    {
        public GUI_Syllabus_Objectives_Add()
        {
            InitializeComponent();
        }
        public string idobj ="";
        public string ids = "";
        SyllabusObjBLL syso = new SyllabusObjBLL();
        DicBLL dc = new DicBLL();
        private void GUI_Syllabus_Objectives_Add_Load(object sender, EventArgs e)
        {
            if(idobj != "")
            {
                rtObjectives.Text = syso.loadobj(idobj).Single().ObjSContent;
            }
            else
            {
                rtObjectives.Text = "";
            }
        }
        string temp;
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isempty = false;
            
            if(rtObjectives.Text == null || rtObjectives.Text == "")
            {
                temp = temp + dc.sysllabusobj("missingcontent") + "\n";
                isempty = true;
            }
            string content = rtObjectives.Text;
            if (isempty == false)
            {
                if (idobj == "")
                {
                    if (syso.AddObj(ids, content) == true)
                    {
                        MessageBox.Show(dc.sysllabusobj("success"));
                        rtObjectives.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(dc.sysllabusobj("else"));
                    }
                }
                else
                {
                    if(syso.EditObj(idobj,content)==true)
                    {
                        MessageBox.Show(dc.sysllabusobj("edit"));
                    }
                    else
                    {
                        MessageBox.Show(dc.sysllabusobj("else"));
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
