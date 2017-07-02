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
    public class CreateTable
    {
        EprogramDataContext db = new EprogramDataContext();

        //DocX templ = DocX.Load("");
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


















        public void X()
        {
            DocX gDoc;

            try
            {

                gDoc = fillProgram(DocX.Load("C:\\Users\\Admin\\Desktop\\ChuongTrinhDaoTao_Teamplate.docx"), "PR0001");
                gDoc.SaveAs(@"newFile.docx");
  
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
