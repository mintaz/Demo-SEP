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
        public string idprout = "";
        public string idp = "";
        ProgramOutBLL prou = new ProgramOutBLL();
        ProgramBLL pr = new ProgramBLL();
        DicBLL dc = new DicBLL();
        void clean()
        {
            txtProgramOutNo.Text = "";
            cboOutcomeType.SelectedValue = 1;
            rcOutcomes.Text = "";
        }
        private void GUI_Program_Outcomes_AddEdit_Load(object sender, EventArgs e)
        {
            if (pr.getLock(idp) == true)
            {
                txtProgramOutNo.ReadOnly = true;
                rcOutcomes.ReadOnly = true;
                btnOutcomesSave.Enabled = false;
            }
            var list = new[]
           {
                new { Text = "Về Kiến Thức",Value =1},
                new { Text = "Về kỹ năng, thái độ và đạo đức nghề nghiệp",Value =2},
                new { Text = "Về khả năng công tác", Value = 3}
            };
            cboOutcomeType.DataSource = list;
            cboOutcomeType.DisplayMember = "Text";
            cboOutcomeType.ValueMember = "Value";
            if(idprout == "")
            {
                clean();
            }
            else
            {
                
                txtProgramOutNo.Text = prou.LoadOutcomes(idprout).Single().OutcomeNo;
                cboOutcomeType.SelectedValue = prou.LoadOutcomes(idprout).Single().OutcomeType;
                rcOutcomes.Text = prou.LoadOutcomes(idprout).Single().OutcomeContent;
            }
        }
        EprogramDataContext db = new EprogramDataContext();
        private void btnOutcomesSave_Click(object sender, EventArgs e)
        {
            if (txtProgramOutNo.Text == null || txtProgramOutNo.Text == "")
            {
                txtProgramOutNo.Text = "0";
            }
            if(rcOutcomes.Text == null)
            {
                rcOutcomes.Text = "";
            }
            string no = txtProgramOutNo.Text;
            int type = int.Parse(cboOutcomeType.SelectedValue.ToString());
            string con = rcOutcomes.Text;

            if(idprout == "")
            {
                int notest = db.ProgramOutcomes.Where(s => s.OutcomeNo.Contains(no)).Count();
                if ( notest ==0 )
                {
                    if (prou.AddProOut(idp, no, type, con) == true)
                    {
                        MessageBox.Show(dc.successProgramOut("addprogramoutcome"));
                        clean();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(dc.successProgramOut("else"));
                    }
                }
                else
                {
                    MessageBox.Show(dc.errorProOut("sameno"));
                }
            }
            else
            {
                if (prou.EditProOut(idprout, no, type, con) == true)
                {
                    MessageBox.Show(dc.successProgramOut("editprogramoutcome"));
                    clean();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(dc.successProgramOut("else"));
                }
            }
        }
    }
}
