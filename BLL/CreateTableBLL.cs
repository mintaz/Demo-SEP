using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Novacode;
using System.IO;
using DAL;
using BLL;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace BLL
{
    public class CreateTableBLL
    {
        EprogramDataContext db = new EprogramDataContext();

        public DocX fillProgram(DocX temp,string idProgram)
        {
            Program profill = db.Programs.Where(pro => pro.id == idProgram).Single();
            temp.ReplaceText("[ProgramName]", profill.name, false);
            temp.ReplaceText("[ProgramLevel]", profill.ProgramLevel, false);
            temp.ReplaceText("[ProgramBranch]", profill.ProgramBranch, false);
            temp.ReplaceText("[ProgramType]", profill.ProgramType, false);
            temp.ReplaceText("[ProgramTime]", profill.ProgramTime, false);
            temp.ReplaceText("[ProgramVolume]", profill.ProgramVolume, false);
            temp.ReplaceText("[ProgramActor]", profill.ProgramActor, false);
            temp.ReplaceText("[ProgramProcess]", profill.ProgramProcess, false);
            temp.ReplaceText("[ProgramMark]", ("Tối đa:" + profill.ProgramPoint.ToString()), false);
            temp.ReplaceText("[ProgramOutcome#1]", programoutcomeslist(idProgram, 1), false);
            temp.ReplaceText("[ProgramOutcome#2]", programoutcomeslist(idProgram, 2), false);
            temp.ReplaceText("[ProgramOutcome#3]", programoutcomeslist(idProgram, 3), false);
            temp.ReplaceText("[ProgramPoint]", profill.ProgramTC.ToString(), false);
            temp.ReplaceText("[ProgramPackage]", profill.ProgramPackage,false);
            temp.ReplaceText("[TableLecturerList]", profill.ProgramLecturer, false);
            var t = temp.Tables[0];
            var t1 = temp.Tables[1];
            CreateAndInsertCourseTableAfter(t, ref temp,idProgram);
            CreateAndInsertDetailTableAfter(t1, ref temp, idProgram, 1);
            t1.Remove();
            t.Remove();
            return temp;
        }
        public string programoutcomeslist(string id,int type)
        {
            string str = "";
            try
            {
                foreach(var item in db.ProgramOutcomes.Where(st => st.idProgram == id && st.OutcomeType == type).ToList())
                {
                    str = str + item.OutcomeContent + "\n";
                }
                return str;
            }
            catch
            {
                return "";
            }
        }

        public string syllabusobje(string id)
        {
            string str = "";
            try
            {
                foreach (var item in db.SyllabusObjectives.Where(st => st.id == id).ToList())
                {
                    str = str + item.ObjSContent + "\n";
                }
                return str;
            }
            catch
            {
                return "";
            }
        }
        public string syllabusoutcomeslist(string id)
        {
            string str = "";
            try
            {
                foreach (var item in db.SyllabusOutcomes.Where(st => st.id == id).ToList())
                {
                    str = str + item.OutcomeNo +". " + item.OutcomeContent + "\n";
                }
                return str;
            }
            catch
            {
                return "";
            }
        }
        public DocX fillSyllabus(DocX temp1, string idSyllabus,string idprogram)
        {
            Syllabus sylfill = db.Syllabus.Where(pro => pro.id == idSyllabus).Single();
            Program profill2 = db.Programs.Where(pro => pro.id == idprogram).Single();
            string idacc = sylfill.idAccount;
            string name = db.Accounts.Where(ac => ac.id == idacc).Single().name;
            temp1.ReplaceText("[SyllabusName]", sylfill.name, false);
            temp1.ReplaceText("[SyllabusCode]", sylfill.CourseCode, false);
            temp1.ReplaceText("[LecturerName]", name, false);
            temp1.ReplaceText("[SyllabusLecturerInfo]", sylfill.CourseLecturer, false);
            temp1.ReplaceText("[SyllabusPoint]", sylfill.CoursePoint.ToString(), false);
            temp1.ReplaceText("[SyllabusLevel]", sylfill.CourseLevel, false);
            temp1.ReplaceText("[SyllabusTime]", sylfill.CourseTime, false);
            temp1.ReplaceText("[SyllabusPreCourse]", sylfill.PreCourse, false);
            temp1.ReplaceText("[SyllabusObjective]", syllabusobje(idSyllabus), false);
            temp1.ReplaceText("[SyllabusOutcome]", syllabusoutcomeslist(idSyllabus), false);
            temp1.ReplaceText("[SyllabusDescription]", sylfill.CourseDescription, false);
            temp1.ReplaceText("[SyllabusDocument]", sylfill.CourseDocument, false);
            temp1.ReplaceText("[SyllabusMethods]", sylfill.CourseMethod, false);
            temp1.ReplaceText("[SyllabusRequest]", sylfill.CourseRequest, false);
            var t = temp1.Tables[0];
            var t1 = temp1.Tables[1];
            var t2 = temp1.Tables[2];
            var t3 = temp1.Tables[3];
            var t4 = temp1.Tables[4];
            var t5 = temp1.Tables[5];
            var t6 = temp1.Tables[6];
            var t7 = temp1.Tables[7];
            var t8 = temp1.Tables[8];
            int type = db.Syllabus.Where(pro => pro.id == idSyllabus).Single().CourseType.Value;
            if(type == 0)
            {
                t1.Remove();
                t2.Remove();
                t3.Remove();
                t4.Remove();
                t5.Remove();
            }
            if (type == 1)
            {
                t.Remove();
                t2.Remove();
                t3.Remove();
                t4.Remove();
                t5.Remove();
            }
            if (type == 2)
            {
                t1.Remove();
                t.Remove();
                t3.Remove();
                t4.Remove();
                t5.Remove();
            }
            if (type == 3)
            {
                t1.Remove();
                t2.Remove();
                t.Remove();
                t4.Remove();
                t5.Remove();
            }
            if (type == 4)
            {
                t1.Remove();
                t2.Remove();
                t3.Remove();
                t.Remove();
                t5.Remove();
            }
            if (type == 5)
            {
                t1.Remove();
                t2.Remove();
                t3.Remove();
                t4.Remove();
                t.Remove();
            }
            CreateMappingTableAfter(t6, ref temp1, idSyllabus, idprogram);
            CreateMethod(t7, ref temp1, idSyllabus, idprogram);
            CreateSchedule(t8, ref temp1, idSyllabus, idprogram);
            t6.Remove();
            t7.Remove();
            t8.Remove();
            return temp1;
        }

        private Table CreateAndInsertCourseTableAfter(Table t, ref DocX document,string idprogram)
        {
            var data = db.Syllabus.Where(sys => sys.idProgram == idprogram).ToList();

            var Tabler = t.InsertTableAfterSelf(data.Count +1, 5);
            var tableTitle = new Formatting();
            tableTitle.Bold = true;

            Tabler.Rows[0].Cells[0].InsertParagraph("STT",false,tableTitle);
            Tabler.Rows[0].Cells[1].InsertParagraph("Mã MH", false, tableTitle);
            Tabler.Rows[0].Cells[2].InsertParagraph("Môn Học", false, tableTitle);
            Tabler.Rows[0].Cells[3].InsertParagraph("TC", false, tableTitle);
            Tabler.Rows[0].Cells[4].InsertParagraph("Học Kỳ", false, tableTitle);
            int index = 1;

            foreach(var item in data)
            {
                Tabler.Rows[index].Cells[0].InsertParagraph(index.ToString(), false);
                Tabler.Rows[index].Cells[1].InsertParagraph(item.CourseCode, false);
                Tabler.Rows[index].Cells[2].InsertParagraph(item.name, false);
                Tabler.Rows[index].Cells[3].InsertParagraph(item.CoursePoint.ToString(), false);
                Tabler.Rows[index].Cells[4].InsertParagraph(item.CourseSemester.ToString(), false);
                index++;
            }


            return Tabler;
        }
        private Table CreateAndInsertDetailTableAfter(Table t, ref DocX document, string idprogram,int numb)
        {
            var data = db.Syllabus.Where(sys => sys.idProgram == idprogram && sys.CourseSemester == numb).ToList();

            var Tabler = t.InsertTableAfterSelf(data.Count + 2, 7);
            var tableTitle = new Formatting();
            tableTitle.Bold = true;
            Tabler.Rows[0].Cells[0].InsertParagraph("Học Kỳ "+numb.ToString(), false);
            Tabler.Rows[0].MergeCells(0, 6);
            Tabler.Rows[1].Cells[0].InsertParagraph("STT", false, tableTitle);
            Tabler.Rows[1].Cells[1].InsertParagraph("Mã MH", false, tableTitle);
            Tabler.Rows[1].Cells[2].InsertParagraph("Môn Học", false, tableTitle);
            Tabler.Rows[1].Cells[3].InsertParagraph("TC", false, tableTitle);
            Tabler.Rows[1].Cells[4].InsertParagraph("TS", false, tableTitle);
            Tabler.Rows[1].Cells[5].InsertParagraph("LT", false, tableTitle);
            Tabler.Rows[1].Cells[6].InsertParagraph("TH/BT", false, tableTitle);
            int index = 2;

            foreach (var item in data)
            {
                Tabler.Rows[index].Cells[0].InsertParagraph((index-1).ToString(), false);
                Tabler.Rows[index].Cells[1].InsertParagraph(item.CourseCode, false);
                Tabler.Rows[index].Cells[2].InsertParagraph(item.name, false);
                Tabler.Rows[index].Cells[3].InsertParagraph(item.CoursePoint.ToString(), false);
                Tabler.Rows[index].Cells[4].InsertParagraph((item.CoursePoint*15).ToString(), false);
                Tabler.Rows[index].Cells[5].InsertParagraph((item.CourseLT * 15).ToString(), false);
                Tabler.Rows[index].Cells[6].InsertParagraph(((item.CoursePoint-item.CourseLT) * 15).ToString(), false);
                index++;
            }
            return Tabler;
        }

        private Table CreateMappingTableAfter(Table t, ref DocX document, string idSyllabus, string idProgram)
        {
            var data = db.Mappings.Where(map => map.idSyllabus == idSyllabus).ToList();
            int col = db.SyllabusOutcomes.Where(syou => syou.idSyllabus == idSyllabus).Count();
            int row = db.ProgramOutcomes.Where(prou => prou.idProgram == idProgram).Count();
            var Tablemap = t.InsertTableAfterSelf(col + 1, row + 1);
            var tableTitle = new Formatting();
            tableTitle.Bold = true;
            int indexpro = 1;
            foreach( ProgramOutcome pro in db.ProgramOutcomes.Where(pr => pr.idProgram == idProgram).ToList())
            {
                Tablemap.Rows[indexpro].Cells[0].InsertParagraph(pro.OutcomeNo, false);
                indexpro++;
            }
            int indexsys = 1;
            foreach (SyllabusOutcome sys in db.SyllabusOutcomes.Where(s => s.idSyllabus == idSyllabus).ToList())
            {
                Tablemap.Rows[0].Cells[indexsys].InsertParagraph(sys.OutcomeNo, false);
                indexpro++;
            }
            int index = 1;
            MappingBLL maplist = new MappingBLL();
            foreach(var item in data)
            {
                var list = maplist.loadcheckedlist(item.ProgramOutcome);
                for(int i= 1; i<= col; i++)
                {
                    if (list.Contains(Tablemap.Rows[0].Cells[i].ToString()))
                    {
                        Tablemap.Rows[index].Cells[i].InsertParagraph("X", false);
                    }
                }
                index++;
            }

            return Tablemap ;
        }

        

        public Table CreateMethod(Table t, ref DocX document, string idSyllabus, string idProgram)
        {
            var data = db.Mappings.Where(map => map.idSyllabus == idSyllabus).ToList();
            var table = t.InsertTableAfterSelf(data.Count +3,5);
            table.Rows[0].Cells[0].InsertParagraph("Chuẩn đầu ra của môn học ", false);
            table.Rows[0].Cells[1].InsertParagraph("Phương pháp dạy và học", false);
            table.Rows[0].Cells[2].InsertParagraph("Phương pháp kiểm tra, đánh giá sinh viên ", false);
            table.Rows[0].Cells[4].InsertParagraph("Chuẩn đầu ra CTĐT ", false);
            table.Rows[1].Cells[2].InsertParagraph("Phương pháp  ", false);
            table.Rows[1].Cells[3].InsertParagraph("Tỷ trọng (%)  ", false);
            table.Rows[data.Count+3].Cells[0].InsertParagraph("Tổng cộng ", false);
            table.Rows[data.Count + 3].Cells[3].InsertParagraph("100% ", false);
            int index = 3;
            foreach(var item in data)
            {
                table.Rows[index].Cells[0].InsertParagraph("Chuẩn " + item.SyllabusOutcome);
                table.Rows[index].Cells[1].InsertParagraph(item.Methods) ;
                table.Rows[index].Cells[2].InsertParagraph(item.FirstPart +" " + item.FirstPercent +"\n" + item.SecondPart + " " + item.SecondPercent + "\n"+ item.ThirdPart + " " + item.ThirdPercent );
                table.Rows[index].Cells[3].InsertParagraph("chuẩn đầu ra số "+item.ProgramOutcome);
                index++;
            }
            return table;
        }
        
        public Table CreateSchedule(Table t, ref DocX document, string idSyllabus, string idProgram)
        {
            var data = db.SyllabusSchedules.Where(map => map.idSyllabus == idSyllabus).ToList();
            var table = t.InsertTableAfterSelf(data.Count + 1, 5);
            table.Rows[0].Cells[0].InsertParagraph("CBuổi/Tuần/ ngày ", false);
            table.Rows[0].Cells[1].InsertParagraph("Số tiết trên lớp ", false);
            table.Rows[0].Cells[2].InsertParagraph("Nội dung bài học  ", false);
            table.Rows[0].Cells[3].InsertParagraph("Hoạt động dạy và học  ", false);
            table.Rows[0].Cells[4].InsertParagraph("Tài liệu cần đọc  ", false);
            int index = 1;
            foreach(var item in data)
            {
                table.Rows[index].Cells[0].InsertParagraph("Buổi "+index+item.Day.ToString());
                table.Rows[index].Cells[1].InsertParagraph(item.NumberPeriods.ToString());
                table.Rows[index].Cells[2].InsertParagraph(item.LectureContent);
                table.Rows[index].Cells[3].InsertParagraph(item.Activites);
                table.Rows[index].Cells[4].InsertParagraph(item.Doc);
                index++;
            }
            return table;
        }

        public void Program(string id)
        {
            DocX gDoc;

            try
            {

                gDoc = fillProgram(DocX.Load(@"ChuongTrinhDaoTao_Template.docx"), id);
                gDoc.SaveAs(@"Program.docx");
  
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Syllabus(string id,string idprogram)
        {
            DocX gDoc;

            try
            {

                gDoc = fillSyllabus(DocX.Load(@"Syllabus_Template.docx"), id,idprogram);
                gDoc.SaveAs(@"Syllabus.docx");

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ProgramFull(string id)
        {
            DocX gDoc;

            try
            {

                gDoc = fillProgram(DocX.Load(@"ChuongTrinhDaoTaoFull_Template.docx"), id);
                gDoc.SaveAs(@"ProgramFull.docx");

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Full()
        {
            DocX gDoc1;

            try
            {
                gDoc1 = DocX.Load(@"ProgramFull.docx");
                gDoc1.InsertDocument(DocX.Load(@"Syllabus.docx"), true);
                gDoc1.SaveAs(@"Full.docx");

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
