﻿using System;
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
        DicBLL dc = new DicBLL();
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
            if(idprout == "")
            {
                clean();
            }
            else
            {
                txtProgramOutNo.Text = prou.LoadPOutcomes(idprout).Single().OutcomeNo;
                cboOutcomeType.SelectedValue = prou.LoadPOutcomes(idprout).Single().OutcomeType;
                rcOutcomes.Text = prou.LoadPOutcomes(idprout).Single().OutcomeContent;
            }
        }
        EprogramDataContext db = new EprogramDataContext();
        private void btnOutcomesSave_Click(object sender, EventArgs e)
        {
            string no = txtProgramOutNo.Text;
            int type = int.Parse(cboOutcomeType.SelectedValue.ToString());
            string con = rcOutcomes.Text;
            if(idprout == "")
            {
                var notest = (from s in db.ProgramOutcomes where s.OutcomeNo.Contains(no) select s).ToList();
                if (notest == null)
                {
                    if (prou.AddProOut(idp, no, type, con) == true)
                    {
                        MessageBox.Show(dc.successProgramOut("addprogramoutcome"));
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
                }
                else
                {
                    MessageBox.Show(dc.successProgramOut("else"));
                }
            }
        }
    }
}
