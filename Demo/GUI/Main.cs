using System;
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
        public int auth;
        public string idaccountmain;
        public bool admin;
        public string name = "";
        public string idpath="";
        public string idpathsy = "";
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
            barStaticItem1.Caption = name;
            if (admin == false)
            {
                if (auth == 1)
                {
                    pageSyllabus.Visible = false;
                    groupAccountManager.Visible = false;
                    btnAccountReset.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnProgramCreate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnPrintSyllabus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnPrintFull.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else if (auth == 2)
                {
                    pageProgram.Visible = false;
                    groupAccountManager.Visible = false;
                    btnAccountReset.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnPrintFull.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnProgram.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else
                {
                    pageProgram.Visible = false;
                    pageSyllabus.Visible = false;
                    groupAccountManager.Visible = false;
                    btnAccountReset.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                }
            }
            else
            {
                pageSyllabus.Visible = false;
                pageProgramGeneralInfo.Visible = false;
                pagePrint.Visible = false;
                btnProgramCreateSyllabus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            
        }

        private void btnProgramCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformcreateprogram = this.checkexist(typeof(GUI.Program.GUI_Program_List));
            if (checkformcreateprogram != null)
            {
                checkformcreateprogram.Activate();
            }
            else
            {
                GUI.Program.GUI_Program_List formcreateprogram = new GUI.Program.GUI_Program_List();
                formcreateprogram.MdiParent = this;
                formcreateprogram.Show();
            }
        }

        private void btnProgramCreateSyllabus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformsyllabusmana = this.checkexist(typeof(GUI.Program.GUI_Program_CreateSyllabus));
            if (checkformsyllabusmana != null)
            {
                checkformsyllabusmana.Activate();
            }
            else
            {
                GUI.Program.GUI_Program_CreateSyllabus formsyllabusmana = new GUI.Program.GUI_Program_CreateSyllabus();
                formsyllabusmana.MdiParent = this;
                formsyllabusmana.idPrg = idpath;
                formsyllabusmana.Show();
            }
        }

        private void btnProgramInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformprograminfo = this.checkexist(typeof(GUI.Program.GUI_Program_ProgramInfo));
            if (checkformprograminfo != null)
            {
                checkformprograminfo.Activate();
            }
            else
            {
                GUI.Program.GUI_Program_ProgramInfo formprograminfo = new GUI.Program.GUI_Program_ProgramInfo();
                formprograminfo.id = this.idpath;
                formprograminfo.MdiParent = this;
                formprograminfo.Show();
            }
        }

        private void btnProgramLecturerList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformprogramlecturerlist = this.checkexist(typeof(GUI.Program.GUI_Program_Lecturer));
            if (checkformprogramlecturerlist != null)
            {
                checkformprogramlecturerlist.Activate();
            }
            else
            {
                GUI.Program.GUI_Program_Lecturer formlecturerlist = new GUI.Program.GUI_Program_Lecturer();
                formlecturerlist.MdiParent = this;
                formlecturerlist.Show();
            }
        }

        private void btnProgramFacilities_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformprogrampackage = this.checkexist(typeof(GUI.GUI_Program_PackageInfo));
            if (checkformprogrampackage != null)
            {
                checkformprogrampackage.Activate();
            }
            else
            {
                GUI.GUI_Program_PackageInfo formpackage = new GUI.GUI_Program_PackageInfo();
                formpackage.MdiParent = this;
                formpackage.Show();
            }
        }

        private void btnSyllabusCourseInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformpsyllabusinfo = this.checkexist(typeof(GUI.Syllabus.GUI_Syllabus_Info));
            if (checkformpsyllabusinfo != null)
            {
                checkformpsyllabusinfo.Activate();
            }
            else
            {
                GUI.Syllabus.GUI_Syllabus_Info formsyllabusinfo = new GUI.Syllabus.GUI_Syllabus_Info();
                formsyllabusinfo.MdiParent = this;
                formsyllabusinfo.idsysinfo = idpathsy;
                formsyllabusinfo.Show();
            }
        }

        private void btnSyllabusLecturerInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformpsyllabuslecturer = this.checkexist(typeof(GUI.GUI_Syllabus_Lecturer));
            if (checkformpsyllabuslecturer != null)
            {
                checkformpsyllabuslecturer.Activate();
            }
            else
            {
                GUI.GUI_Syllabus_Lecturer formsyllabuslecturer = new GUI.GUI_Syllabus_Lecturer();
                formsyllabuslecturer.MdiParent = this;
                formsyllabuslecturer.Show();
            }
        }

        private void btnSyllabusCourseDescription_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformpsyllabusdes = this.checkexist(typeof(GUI.GUI_Syllabus_Description));
            if (checkformpsyllabusdes != null)
            {
                checkformpsyllabusdes.Activate();
            }
            else
            {
                GUI.GUI_Syllabus_Description formsyllabusdes = new GUI.GUI_Syllabus_Description();
                formsyllabusdes.MdiParent = this;
                formsyllabusdes.Show();
            }
        }

        private void btnSyllabusDocument_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformpsyllabusdoc = this.checkexist(typeof(GUI.GUI_Syllabus_Document));
            if (checkformpsyllabusdoc != null)
            {
                checkformpsyllabusdoc.Activate();
            }
            else
            {
                GUI.GUI_Syllabus_Document formsyllabusdoc = new GUI.GUI_Syllabus_Document();
                formsyllabusdoc.MdiParent = this;
                formsyllabusdoc.Show();
            }
        }

        private void btnSyllabusRequirement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformpsyllabusreq = this.checkexist(typeof(GUI.GUI_Syllabus_Request));
            if (checkformpsyllabusreq != null)
            {
                checkformpsyllabusreq.Activate();
            }
            else
            {
                GUI.GUI_Syllabus_Request formsyllabusreq = new GUI.GUI_Syllabus_Request();
                formsyllabusreq.MdiParent = this;
                formsyllabusreq.Show();
            }
        }

        private void btnSyllabusSchedule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformpsyllabussche = this.checkexist(typeof(GUI.Syllabus.GUI_Syllabus_ScheduleManager));
            if (checkformpsyllabussche != null)
            {
                checkformpsyllabussche.Activate();
            }
            else
            {
                GUI.Syllabus.GUI_Syllabus_ScheduleManager formsyllabussche = new GUI.Syllabus.GUI_Syllabus_ScheduleManager();
                formsyllabussche.MdiParent = this;
                formsyllabussche.Show();
            }
        }

        private void btnSyllabusObjectives_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformpsyllabussobj = this.checkexist(typeof(GUI.Syllabus.GUI_Syllabus_Objectives));
            if (checkformpsyllabussobj != null)
            {
                checkformpsyllabussobj.Activate();
            }
            else
            {
                GUI.Syllabus.GUI_Syllabus_Objectives formsyllabussobj = new GUI.Syllabus.GUI_Syllabus_Objectives();
                formsyllabussobj.MdiParent = this;
                formsyllabussobj.idsys = idpathsy;
                formsyllabussobj.Show();
            }
        }

        private void btnSyllabusOutcomes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformpsyllabussout = this.checkexist(typeof(GUI.Syllabus.GUI_Syllabus_Outcomes));
            if (checkformpsyllabussout != null)
            {
                checkformpsyllabussout.Activate();
            }
            else
            {
                GUI.Syllabus.GUI_Syllabus_Outcomes formsyllabussout = new GUI.Syllabus.GUI_Syllabus_Outcomes();
                formsyllabussout.MdiParent = this;
                formsyllabussout.idsys = idpathsy;
                formsyllabussout.Show();
            }
        }

        private void btnSyllabusMapping_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformpsyllabussmapping = this.checkexist(typeof(GUI.Syllabus.GUI_Syllabus_Map));
            if (checkformpsyllabussmapping != null)
            {
                checkformpsyllabussmapping.Activate();
            }
            else
            {
                GUI.Syllabus.GUI_Syllabus_Map formsyllabussmapping = new GUI.Syllabus.GUI_Syllabus_Map();
                formsyllabussmapping.MdiParent = this;
                formsyllabussmapping.idsy = idpathsy;
                formsyllabussmapping.idpo = idpath;
                formsyllabussmapping.Show();
            }
        }

        private void btnSyllabusMethod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformpsyllabussmethodmap = this.checkexist(typeof(GUI.Syllabus.GUI_Syllabus_MethodMapp));
            if (checkformpsyllabussmethodmap != null)
            {
                checkformpsyllabussmethodmap.Activate();
            }
            else
            {
                GUI.Syllabus.GUI_Syllabus_MethodMapp formsyllabusmethodmap = new GUI.Syllabus.GUI_Syllabus_MethodMapp();
                formsyllabusmethodmap.MdiParent = this;
                formsyllabusmethodmap.Show();
            }
        }

        private void btnAccountManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformaccountmanager = this.checkexist(typeof(GUI.Account.GUI_Account_Manager));
            if (checkformaccountmanager != null)
            {
                checkformaccountmanager.Activate();
            }
            else
            {
                GUI.Account.GUI_Account_Manager formaccountmanager = new GUI.Account.GUI_Account_Manager();
                formaccountmanager.MdiParent = this;
                formaccountmanager.Show();
            }
        }

        private void btnAccountReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.GUI_Account_ResetPass formresetpass = new GUI.GUI_Account_ResetPass();
            formresetpass.ShowDialog();
        }

        private void btnAccountChange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.GUI_Account_ChangePass formchangpass = new GUI.GUI_Account_ChangePass();
            formchangpass.ShowDialog();
        }

        private void btnProgramOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkforprogramout = this.checkexist(typeof(GUI.Program.GUI_Program_Outcomes));
            if (checkforprogramout != null)
            {
                checkforprogramout.Activate();
            }
            else
            {
                GUI.Program.GUI_Program_Outcomes formprogramout = new GUI.Program.GUI_Program_Outcomes();
                formprogramout.MdiParent = this;
                formprogramout.idprogram = idpath;
                formprogramout.Show();
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.Close();
        }
    }
}
