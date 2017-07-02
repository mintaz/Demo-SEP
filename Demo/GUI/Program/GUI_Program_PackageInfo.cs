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
namespace Demo.GUI
{
    public partial class GUI_Program_PackageInfo : Form
    {
        public GUI_Program_PackageInfo()
        {
            InitializeComponent();
        }
        public string idprogram = "";
        EprogramDataContext db = new EprogramDataContext();
        private void GUI_Program_PackageInfo_Load(object sender, EventArgs e)
        {
            if (p.getLock(idprogram) == true)
            {
                richtextboxPackage.ReadOnly = true;
                fileSaveItem1.Enabled = false;
            }
            try
            {
                richtextboxPackage.Text = db.Programs.Where(pro => pro.id == idprogram).Single().ProgramPackage;
            }
            catch
            {
                richtextboxPackage.Text = "";
            }

        }
        ProgramBLL p = new ProgramBLL();
        private void fileSaveItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (richtextboxPackage.Text == null)
            {
                richtextboxPackage.Text = "";
            }
            if (p.UpdatePackage(idprogram, richtextboxPackage.Text))
            {
                MessageBox.Show("Cập nhập thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi đường truyền, vui lòng thử lại sau.");
            }
        }
    }
}
