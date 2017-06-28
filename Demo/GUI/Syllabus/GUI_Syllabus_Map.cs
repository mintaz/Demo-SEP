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
using System.Collections;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data;
using DevExpress.XtraEditors;

namespace Demo.GUI.Syllabus
{
    public partial class GUI_Syllabus_Map : Form
    {
        public GUI_Syllabus_Map()
        {
            InitializeComponent();
        }
        EprogramDataContext db = new EprogramDataContext();
        MappingBLL map = new MappingBLL();
        public string idsy = "";
        public string idpo = "";
        void loadDB()
        {
            lsSyllabusOut.DataSource = map.loadSyOut(idsy);
            lsSyllabusOut.DisplayMember = "id";
            lsSyllabusOut.ValueMember = "id";
            lsSyllabusOut.SelectedIndex = 0;
            lsProgramOut.DataSource = map.loadPrOut(idpo);
            lsProgramOut.DisplayMember = "id";
            lsProgramOut.ValueMember = "id";
        }

        //load các checked items từ list
        void loadchecked(List<string> listchec)
        {
            for (int i = 0; i < lsProgramOut.ItemCount; i++)
            {
                if (listchec.Contains(lsProgramOut.GetItemValue(i).ToString()) == true)
                {
                    lsProgramOut.SetItemChecked(i, true);
                }
            }
        }

        private void GUI_Syllabus_Map_Load(object sender, EventArgs e)
        {
            loadDB();
            string sts = lsSyllabusOut.GetItemValue(index).ToString();
            string stp = map.loadmap(sts);
            loadchecked(map.loadcheckedlist(stp));
        }
    

        int index = 0;
        private void lsSyllabusOut_Click(object sender, EventArgs e)
        {

            index = lsSyllabusOut.SelectedIndex;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string sts = lsSyllabusOut.GetItemValue(index).ToString();

            List<string> lzs = new List<string>();
            foreach (ProgramOutcome item in lsProgramOut.CheckedItems)
            {
                lzs.Add(item.id);
            }
            string prostring = map.createString(lzs);
            if (map.checkexistid(sts) == true)
            {
                
                map.ChangePro(sts, prostring);
            }
            else
            {
                map.AddMap(idsy, sts, prostring);
            }
        }

        private void txtLoad_Click(object sender, EventArgs e)
        {

            string sts = lsSyllabusOut.GetItemValue(index).ToString();
            if (map.checkexistid(sts) == true) {
                string stp = map.loadmap(sts);
                loadchecked(map.loadcheckedlist(stp));
            }
            else
            {
                lsProgramOut.UnCheckAll();
            }

        }
    }
}
