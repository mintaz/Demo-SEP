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

namespace Demo.GUI
{
    public partial class GUI_Program_Outcomes_AddEdit : Form
    {
        public GUI_Program_Outcomes_AddEdit()
        {
            InitializeComponent();
        }
        public string idp = "";
        ProgramOutBLL prou = new ProgramOutBLL();
        void clean()
        {
            txtProgramOutNo.Text = "";
            cboOutcomeType.SelectedValue = 1;
            rcOutcomes.Text = "";
        }
        private void GUI_Program_Outcomes_AddEdit_Load(object sender, EventArgs e)
        {
            var list = new[]
           {
                new { Text = "Về Kiến Thức",Value =1},
                new { Text = "Về kỹ năng, thái độ và đạo đức nghề nghiệp",Value =2},
                new { Text = "Về khả năng công tác", Value = 3}
            };
            cboOutcomeType.DataSource = list;
            cboOutcomeType.DisplayMember = "Text";
            cboOutcomeType.ValueMember = "Value";
            if(idp == "")
            {
                clean();
            }
            else
            {
                txtProgramOutNo.Text = prou.LoadPOutcomes(idp).Single().OutcomeNo;
                cboOutcomeType.SelectedValue = prou.LoadPOutcomes(idp).Single().OutcomeType;
                rcOutcomes.Text = prou.LoadPOutcomes(idp).Single().OutcomeContent;
            }
        }

        private void btnOutcomesSave_Click(object sender, EventArgs e)
        {

        }
    }
}
