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

namespace Demo.GUI.Print
{
    public partial class GUI_Print_PrintAll : Form
    {
        public GUI_Print_PrintAll()
        {
            InitializeComponent();
        }
        public string idprogram ="";
        CreateTableBLL table = new CreateTableBLL();
        SyllabusBLL sys = new SyllabusBLL();
        private void GUI_Print_PrintAll_Load(object sender, EventArgs e)
        {
            table.ProgramFull(idprogram);
            foreach (var syl in sys.loadSyllabus(idprogram).ToList())
            {
                table.Syllabus(syl.id, syl.idProgram);
                table.Full();
            }
            RichEditDocumentServer f = new RichEditDocumentServer();
            f.LoadDocument(@"Full.docx");

            printableComponentLink1.Component = f;
            documentViewer1.DocumentSource = printingSystem1;
        }
    }
}
