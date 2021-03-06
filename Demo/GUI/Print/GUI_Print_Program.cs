﻿using System;
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
using System.IO;

namespace Demo.GUI.Print
{
    public partial class GUI_Print_Program : Form
    {
        public GUI_Print_Program()
        {
            InitializeComponent();
        }
        public string idprogram = "";
        CreateTableBLL table = new CreateTableBLL();
        private void GUI_Print_Program_Load(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            table.Program(idprogram, appPath);
            RichEditDocumentServer f = new RichEditDocumentServer();
            f.LoadDocument(appPath+"\\Program.docx");
            printableComponentLink2.Component = f;
            documentViewer1.DocumentSource = printingSystem1;
        }
    }
}
