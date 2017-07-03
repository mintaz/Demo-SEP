using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
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
        
        SyllabusOutBLL syo = new SyllabusOutBLL();
        MappingBLL ma = new MappingBLL();
        SyllabusBLL syl = new SyllabusBLL();
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
            if (pro.getLock(idpath) == true)
            {
                btnsubmit.Enabled = false;
                btnlock.Enabled = false;
            }
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
                    if (pro.getLock(idpath) == false)
                    {
                        btnunlock.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    }
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
                    btnProgram.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnPrintSyllabus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnAccountReset.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                }
            }
            else
            {
                pageSyllabus.Visible = false;
                pageProgramGeneralInfo.Visible = false;
                pagePrint.Visible = false;
                btnProgramCreateSyllabus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                pagesubmit.Visible = false;
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
        ProgramBLL pro = new ProgramBLL();
        private void btnProgramCreateSyllabus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pro.getcheckcan(idpath))
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
            else
            {
                MessageBox.Show("Bạn phải cập nhập thông tin chương trình đào tạo trước khi phân công môn học. \nVui lòng thử lại.");
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
            Form checkformprogramlecturerlist = this.checkexist(typeof(GUI.Program.GUI_Program_OtherInfo));
            if (checkformprogramlecturerlist != null)
            {
                checkformprogramlecturerlist.Activate();
            }
            else
            {
                GUI.Program.GUI_Program_OtherInfo formlecturerlist = new GUI.Program.GUI_Program_OtherInfo();
                formlecturerlist.MdiParent = this;
                formlecturerlist.idprogram = idpath;
                formlecturerlist.Show();
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
                formsyllabusinfo.idp = syl.getIDprogram(idpathsy);
                formsyllabusinfo.Show();
            }
        }

        private void btnSyllabusLecturerInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformpsyllabuslecturer = this.checkexist(typeof(GUI.Syllabus.GUI_Syllabus_OtherInfo));
            if (checkformpsyllabuslecturer != null)
            {
                checkformpsyllabuslecturer.Activate();
            }
            else
            {
                GUI.Syllabus.GUI_Syllabus_OtherInfo formsyllabuslecturer = new GUI.Syllabus.GUI_Syllabus_OtherInfo();
                formsyllabuslecturer.MdiParent = this;
                formsyllabuslecturer.ids = idpathsy;
                formsyllabuslecturer.idp = syl.getIDprogram(idpathsy);
                formsyllabuslecturer.Show();
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
                formsyllabussche.idS = idpathsy;
                formsyllabussche.idp = syl.getIDprogram(idpathsy);
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
                formsyllabussobj.idp = syl.getIDprogram(idpathsy);
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
                formsyllabussout.idp = syl.getIDprogram(idpathsy);
                formsyllabussout.Show();
            }
        }

        private void btnSyllabusMapping_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (syo.getCount(idpathsy) > 0)
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
                    formsyllabussmapping.idpo = syl.getIDprogram(idpathsy);
                    formsyllabussmapping.Show();
                }
            }
            else
            {
                MessageBox.Show("Hiện tại chưa có đầu ra môn học để thực hiện Ma trận Liên kết.\nVui lòng kiểm tra lại.");
            }
        }

        private void btnSyllabusMethod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ma.getCount(idpathsy) > 0)
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
                    formsyllabusmethodmap.idS = idpathsy;
                    formsyllabusmethodmap.idp = idpath;
                    formsyllabusmethodmap.Show();
                }
            }
            else
            {
                MessageBox.Show("Hiện tại chưa có Ma Trận Liên Kết môn học để thực hiện Phương pháp đánh giá.\nVui lòng kiểm tra lại.");
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
        public bool log = false;
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            log = true;
            this.Close();
        }
        
        private void btnPrintSyllabus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkformprintsyllabus = this.checkexist(typeof(GUI.Program.GUI_Program_Outcomes));
            if (checkformprintsyllabus != null)
            {
                checkformprintsyllabus.Activate();
            }
            else
            {
                GUI.Print.GUI_Print_Syllabus formprintsyllabus = new GUI.Print.GUI_Print_Syllabus();
                formprintsyllabus.MdiParent = this;
                formprintsyllabus.idS = idpathsy;
                formprintsyllabus.Show();
            }
        }

        private void btnPrintFull_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkprintfull = this.checkexist(typeof(GUI.Program.GUI_Program_Outcomes));
            if (checkprintfull != null)
            {
                checkprintfull.Activate();
            }
            else
            {
                GUI.Print.GUI_Print_PrintAll printfull = new GUI.Print.GUI_Print_PrintAll();
                printfull.MdiParent = this;
                printfull.idprogram = idpath;
                printfull.Show();
            }
        }

        private void btnProgram_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form checkprintprogram = this.checkexist(typeof(GUI.Program.GUI_Program_Outcomes));
            if (checkprintprogram != null)
            {
                checkprintprogram.Activate();
            }
            else
            {
                GUI.Print.GUI_Print_Program printpro = new GUI.Print.GUI_Print_Program();
                printpro.MdiParent = this;
                printpro.idprogram = idpath;
                printpro.Show();
            }
        }
        EprogramDataContext db = new EprogramDataContext();
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn hoàn thành việc xây dựng chương trình đào tạo chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                foreach(Syllabus item in db.Syllabus.Where(s => s.idProgram == idpath).ToList())
                {
                    item.isLockEdit = true;
                    db.SubmitChanges();
                }
                MessageBox.Show("Cập nhập thành công, bạn không thể xóa môn học.");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn khóa chương trình đào tạo chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                pro.setlock(idpath);
                MessageBox.Show("Đã khóa chương trình đào tạo.");
                log = true;
                this.Close();
            }
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI.Program.GUI_Enter_Pass enterpass = new GUI.Program.GUI_Enter_Pass();
            enterpass.ShowDialog();
            MessageBox.Show("Chương trình sẽ thoát vì lý do bảo mật, vui lòng đăng nhập lại");
            log = true;
            this.Close();
        }

        private void btnSyllabusRequirement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
