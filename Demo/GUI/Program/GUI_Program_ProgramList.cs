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
    public partial class GUI_Program_ProgramList : Form
    {
        public GUI_Program_ProgramList()
        {
            InitializeComponent();
        }
        EprogramDataContext db = new EprogramDataContext();
        private void GUI_Program_ProgramList_Load(object sender, EventArgs e)
        {
            var info = (from c in db.Programs
                        where c.idAccount == "T170001"
                        select new
                        {
                            c.id,
                            c.name
                        }).Union(from c in db.Syllabus
                                 where c.idAccount == "T170001"
                                 select new
                                 {
                                     c.id,
                                     c.name
                                 });
            gcProgramList.DataSource = info.ToList();
        }
    }
}
