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
            if (ckMid.Checked == true)
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


            if (id == "")
            {
                if (ss.check(idS, number) == false)
                {
                    if (ss.AddSche(idS, dt, number, con, act, doc, mid) == true)
                    {
                        MessageBox.Show(dc.schedule("success"));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(dc.schedule("else"));
                    }
                }
                else
                {
                    MessageBox.Show(dc.schedule("over") + "\nVui lòng kiểm tra lại");
                }
            }
            else
            {

                int oldnum = ss.SingleSche(id).Single().NumberPeriods.Value;
                int newnum = 0;
                try
                {
                    newnum = int.Parse(txtPeriods.Text);
                }
                catch
                {
                    newnum = 0;
                }
                if (newnum <= (int.Parse(txtcount.Text) + oldnum))
                    if (ss.EditSche(id, dt, number, con, act, doc, mid) == true)
                    {
                        MessageBox.Show(dc.schedule("edit"));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(dc.schedule("else"));
                    }
                else
                {
                    MessageBox.Show(dc.schedule("over") + "\nVui lòng kiểm tra lại");
                }
            }
        }
        ScheduleBLL ss = new ScheduleBLL();
        void loaddata()
        {
            if (id != "")
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
            txtcount.Text = ss.getsto(idS);
        }
        private void GUI_Syllabus_Schedule_Load(object sender, EventArgs e)
        {
            txtcount.ReadOnly = true;
            loaddata();
        }

        private void txtPeriods_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
