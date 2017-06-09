﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }
        private Form checkexist(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //pagePrint.Visible = false;
            pageSyllabus.Visible = false;
            //groupProgramObjectiveOutcome.Visible = false;
            //pageProgramGeneralInfo.Visible = false;
            groupAccountManager.Visible = false;
            btnPrintReviewSyllabus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnPrintSyllabus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //btnAccountManager.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void btnProgramFacilities_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form formFacilitiescheck = this.checkexist(typeof(GUI.GUI_Program_PackageInfo));
            if (formFacilitiescheck !=null)
            {
                formFacilitiescheck.Activate();
            }
            else
            {
                GUI.GUI_Program_PackageInfo formFacilities = new GUI.GUI_Program_PackageInfo();
                formFacilities.MdiParent = this;
                formFacilities.Show();
            }
        }
    }
}
