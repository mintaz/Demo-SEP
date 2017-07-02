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
    public partial class GUI_Program_CreateProgram : Form
    {
        public GUI_Program_CreateProgram()
        {
            InitializeComponent();
        }
        AccountBLL ac = new AccountBLL();
        ProgramBLL p = new ProgramBLL();
        DicBLL dc = new DicBLL();
        public string idprogram="";
        public string idacc="";
        private void GUI_Program_CreateProgram_Load(object sender, EventArgs e)
        {
            if (idprogram == "")
            {
                cboProgramMaster.DataSource = ac.LoadAccount();
                cboProgramMaster.DisplayMember = "name";
                cboProgramMaster.ValueMember = "id";
            } else
            {
                cboProgramMaster.DataSource = ac.LoadAccount();
                cboProgramMaster.DisplayMember = "name";
                cboProgramMaster.ValueMember = "id";
                cboProgramMaster.SelectedValue = idacc;
                txtProgramName.Text = p.LoadProgram(idprogram).Single().name;
            }
        }

        private void btnProgramSave_Click(object sender, EventArgs e)
        {
            if(txtProgramName.Text == null)
            {
                txtProgramName.Text = "";
            }
            string name = txtProgramName.Text;
            string ida = cboProgramMaster.SelectedValue.ToString();
            if (idprogram == "")
            {
                if (p.CreateProgram(ida, name) == true)
                {
                    MessageBox.Show(dc.successCreateProgram("createprogram"));
                    this.Close();
                }
                else
                {
                    MessageBox.Show(dc.errorCreateProgram("else"));
                }
            }
            else
            {
                if (p.EditProgram(idprogram, name, ida) == true)
                {
                    MessageBox.Show(dc.successCreateProgram("editprogram"));
                    this.Close();
                }
                else
                {
                    MessageBox.Show(dc.errorCreateProgram("else"));
                }
            }
        }
    }
}
