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
    public partial class GUI_Syllabus_MethodMap_Dialog : Form
    {
        public GUI_Syllabus_MethodMap_Dialog()
        {
            InitializeComponent();
        }
        public string idmap = "";
        public string ids = "";
        MappingBLL map = new MappingBLL();
        private void GUI_Syllabus_MethodMap_Dialog_Load(object sender, EventArgs e)
        {
            rtsys.Text = map.singlemap(idmap).Single().SyllabusOutcome;
            rtpro.Text = map.singlemap(idmap).Single().ProgramOutcome;
            rtmethod.Text = map.singlemap(idmap).Single().Methods;
            txtpart1.Text = map.singlemap(idmap).Single().FirstPart;
            txtpart2.Text = map.singlemap(idmap).Single().SecondPart;
            txtpart3.Text = map.singlemap(idmap).Single().ThirdPart;
            txtpercent1.Text = map.singlemap(idmap).Single().FirstPercent.ToString();
            txtpercent2.Text = map.singlemap(idmap).Single().FirstPercent.ToString();
            txtpercent3.Text = map.singlemap(idmap).Single().FirstPercent.ToString();
            txtdesity.Text = map.singlemap(idmap).Single().desity.ToString();
            int count = 0;
            foreach ( var item in map.listmap(ids))
            {
                count += item.desity.Value;
            }
            txtcount.Text = count.ToString();
            txtcount.ReadOnly = true;
            rtsys.ReadOnly = true;
            rtpro.ReadOnly = true;

        }
        DicBLL dc = new DicBLL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string temp = "";
            string method = rtmethod.Text;
            string part1 = txtpart1.Text;
            string part2 = txtpart2.Text;
            string part3 = txtpart3.Text;
            int per1 = int.Parse(txtpercent1.Text);
            int per2 = int.Parse(txtpercent2.Text);
            int per3 = int.Parse(txtpercent3.Text);
            int des = int.Parse(txtdesity.Text);
            if(method == null || method == "")
            {
                temp += dc.errormethod("method") +"\n";
            }
            if(part1 == null || part1 == "")
            {
                temp += dc.errormethod("part1") + "\n";
            }
            if (part2 == null || part2 == "")
            {
                temp += dc.errormethod("part2") + "\n";
            }
            if (part3 == null || part3 == "")
            {
                temp += dc.errormethod("part3") + "\n";
            }
            if (txtpercent1.Text == null || txtpercent1.Text == "")
            {
                temp += dc.errormethod("per1") + "\n";
            }
            if (txtpercent2.Text == null || txtpercent2.Text == "")
            {
                temp += dc.errormethod("per2") + "\n";
            }
            if (txtpercent3.Text == null || txtpercent3.Text == "")
            {
                temp += dc.errormethod("per3") + "\n";
            }
            if (txtdesity.Text == null || txtdesity.Text == "")
            {
                temp += dc.errormethod("des") + "\n";
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpercent1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtpercent2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtpercent3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtdesity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtdesity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
