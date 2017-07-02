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
using BLL;
using DAL;
using System.IO;

namespace Demo.GUI.Print
{
    public partial class GUI_Print_Syllabus : Form
    {
        public GUI_Print_Syllabus()
        {
            InitializeComponent();
        }
        public string idS = "";
        EprogramDataContext db = new EprogramDataContext();
        
        CreateTableBLL table = new CreateTableBLL();
        private void GUI_Print_Syllabus_Load(object sender, EventArgs e)
        {
            string idr = db.Syllabus.Where(s => s.id == idS).Single().idProgram;
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            table.Syllabus(appPath,idS, idr);
            RichEditDocumentServer f = new RichEditDocumentServer();
            f.LoadDocument(appPath+"\\Syllabus.docx");
            printableComponentLink1.Component = f;
            documentViewer1.DocumentSource = printingSystem1;
        }
    }
}
