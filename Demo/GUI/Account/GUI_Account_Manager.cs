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

namespace Demo.GUI.Account
{
    public partial class GUI_Account_Manager : Form
    {
        public GUI_Account_Manager()
        {
            InitializeComponent();
        }
        int index;
        string id = "";
        public void loadData()
        {
            AccountBLL ac = new AccountBLL();
            gcAccount.DataSource = ac.LoadAccount();
        }
        private void GUI_Account_Manager_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.GUI_Account_Manager_AddEdit Add = new GUI_Account_Manager_AddEdit();
            Add.ShowDialog();
            loadData();
        }

        private void gvAccount_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            id = gvAccount.GetRowCellValue(index, this.ID).ToString();
            if (id != "")
            {
                GUI.GUI_Account_Manager_AddEdit Edit = new GUI_Account_Manager_AddEdit();
                Edit.idAc = id;
                Edit.ShowDialog();
            }
            loadData();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            id = gvAccount.GetRowCellValue(index,this.ID).ToString();
            AccountBLL ad = new AccountBLL();
            DicBLL dc = new DicBLL();
            if (MessageBox.Show("Bạn có muốn xóa không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ad.DeleteAccount(id) == true)
                {
                    MessageBox.Show(dc.successAccountMessage("delete"));
                }
                else
                {
                    MessageBox.Show(dc.errorAccountMessage("else"));
                }
                loadData();
            }

        }

        private void gvAccount_DoubleClick(object sender, EventArgs e)
        {
            id = gvAccount.GetRowCellValue(index, this.ID).ToString();
            if (id != "")
            {
                GUI.GUI_Account_Manager_AddEdit Edit = new GUI_Account_Manager_AddEdit();
                Edit.idAc = id;
                Edit.ShowDialog();
            }
            loadData();
        }
    }
}
