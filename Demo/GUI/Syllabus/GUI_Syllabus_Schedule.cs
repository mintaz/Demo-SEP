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
    public partial class GUI_Syllabus_Schedule : Form
    {
        public GUI_Syllabus_Schedule()
        {
            InitializeComponent();
        }
        public string idS = "";
        public string id = "";
        DicBLL dc = new DicBLL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string act = rtAct.Text;
            string con = rtContent.Text;
            string doc = rtDoc.Text;
            bool mid = false;
            if(ckMid.Checked == true)
            {
                mid = true;
                act = "";
                con = "Thi Giữa Học Kỳ";
                doc = "";
            }
            else
            {
                mid = false;
                doc = rtDoc.Text;
                con = rtContent.Text;
                act = rtAct.Text;
            }
            DateTime dt = dtTime.Value.Date;
            int number = int.Parse(txtPeriods.Text);
            if(id == "")
            {
                if(ss.AddSche(idS,dt,number,con,act,doc,mid) == true)
                {
                    MessageBox.Show(dc.schedule("success"));
                }
                else
                {
                    MessageBox.Show(dc.schedule("else"));
                }
            }
            else
            {
                if (ss.EditSche(id, dt, number, con, act, doc, mid) == true)
                {
                    MessageBox.Show(dc.schedule("edit"));
                }
                else
                {
                    MessageBox.Show(dc.schedule("else"));
                }
            }
        }
        ScheduleBLL ss = new ScheduleBLL();
        private void GUI_Syllabus_Schedule_Load(object sender, EventArgs e)
        {
            if(id != "")
            {
                rtAct.Text = ss.SingleSche(id).Single().Activites;
                rtContent.Text = ss.SingleSche(id).Single().LectureContent;
                rtDoc.Text = ss.SingleSche(id).Single().Doc;
                ckMid.Checked = ss.SingleSche(id).Single().mid.Value;
                dtTime.Value = ss.SingleSche(id).Single().Day.Value;
                txtPeriods.Text = ss.SingleSche(id).Single().NumberPeriods.ToString();
            }
            else
            {
                dtTime.Value = DateTime.Now;
                rtAct.Text = "";
                rtContent.Text = "";
                rtDoc.Text = "";
                txtPeriods.Text = "";
            }
        }

        private void txtPeriods_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
