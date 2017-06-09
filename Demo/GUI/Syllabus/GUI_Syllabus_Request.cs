using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.GUI
{
    public partial class GUI_Syllabus_Request : Form
    {
        public GUI_Syllabus_Request()
        {
            InitializeComponent();
        }

        private void GUI_Program_PackageInfo_Load(object sender, EventArgs e)
        {
            richtextboxPackage.LoadDocument("C:\\Users\\Mint\\Desktop\\Template\\Syllabus\\Request.docx");

        }
    }
}
