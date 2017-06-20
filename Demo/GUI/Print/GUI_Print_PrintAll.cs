using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit;

namespace Demo.GUI.Print
{
    public partial class GUI_Print_PrintAll : Form
    {
        public GUI_Print_PrintAll()
        {
            InitializeComponent();
        }

        private void GUI_Print_PrintAll_Load(object sender, EventArgs e)
        {
            RichEditDocumentServer f = new RichEditDocumentServer();
            f.LoadDocument("C:\\Users\\Mint\\Desktop\\ChuongTrinhDaoTao_T.doc");
            //printableComponentLink1.Component = f;
            //documentViewer1.DocumentSource = printingSystem1;
        }
    }
}
