using System.Collections.Generic;
using DAL;
using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for SyllabusBLL</summary>
    [TestClass]
    [PexClass(typeof(SyllabusBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SyllabusBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public SyllabusBLL ConstructorTest()
        {
            SyllabusBLL target = new SyllabusBLL();
            return target;
            // TODO: add assertions to method SyllabusBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for AddPre(String, String)</summary>
        [PexMethod]
        public string AddPreTest(
            [PexAssumeUnderTest]SyllabusBLL target,
            string line,
            string id
        )
        {
            string result = target.AddPre(line, id);
            return result;
            // TODO: add assertions to method SyllabusBLLTest.AddPreTest(SyllabusBLL, String, String)
        }

        /// <summary>Test stub for AddSysllabus(String, String, String, Int32, String, Int32, Int32, Int32, String, String)</summary>
        [PexMethod]
        public bool AddSysllabusTest(
            [PexAssumeUnderTest]SyllabusBLL target,
            string idprogram,
            string sysname,
            string syscode,
            int type,
            string idac,
            int sem,
            int TC,
            int LT,
            string precourse,
            string content
        )
        {
            bool result
               = target.AddSysllabus(idprogram, sysname, syscode, type, idac, sem, TC, LT, precourse, content);
            return result;
            // TODO: add assertions to method SyllabusBLLTest.AddSysllabusTest(SyllabusBLL, String, String, String, Int32, String, Int32, Int32, Int32, String, String)
        }

        /// <summary>Test stub for CreateID()</summary>
        [PexMethod]
        public string CreateIDTest([PexAssumeUnderTest]SyllabusBLL target)
        {
            string result = target.CreateID();
            return result;
            // TODO: add assertions to method SyllabusBLLTest.CreateIDTest(SyllabusBLL)
        }

        /// <summary>Test stub for DelPre(String, String)</summary>
        [PexMethod]
        public string DelPreTest(
            [PexAssumeUnderTest]SyllabusBLL target,
            string line,
            string id
        )
        {
            string result = target.DelPre(line, id);
            return result;
            // TODO: add assertions to method SyllabusBLLTest.DelPreTest(SyllabusBLL, String, String)
        }

        /// <summary>Test stub for EditPSysllabus(String, String, String, Int32, String, Int32, Int32, Int32, String, String)</summary>
        [PexMethod]
        public bool EditPSysllabusTest(
            [PexAssumeUnderTest]SyllabusBLL target,
            string idsys,
            string sysname,
            string syscode,
            int type,
            string idac,
            int sem,
            int TC,
            int LT,
            string precourse,
            string content
        )
        {
            bool result
               = target.EditPSysllabus(idsys, sysname, syscode, type, idac, sem, TC, LT, precourse, content);
            return result;
            // TODO: add assertions to method SyllabusBLLTest.EditPSysllabusTest(SyllabusBLL, String, String, String, Int32, String, Int32, Int32, Int32, String, String)
        }

        /// <summary>Test stub for UpdateSysInfo(String, String, String)</summary>
        [PexMethod]
        public bool UpdateSysInfoTest(
            [PexAssumeUnderTest]SyllabusBLL target,
            string id,
            string level,
            string time
        )
        {
            bool result = target.UpdateSysInfo(id, level, time);
            return result;
            // TODO: add assertions to method SyllabusBLLTest.UpdateSysInfoTest(SyllabusBLL, String, String, String)
        }

        /// <summary>Test stub for checkexist(String)</summary>
        [PexMethod]
        public bool checkexistTest([PexAssumeUnderTest]SyllabusBLL target, string code)
        {
            bool result = target.checkexist(code);
            return result;
            // TODO: add assertions to method SyllabusBLLTest.checkexistTest(SyllabusBLL, String)
        }

        /// <summary>Test stub for getIDprogram(String)</summary>
        [PexMethod]
        public string getIDprogramTest([PexAssumeUnderTest]SyllabusBLL target, string ids)
        {
            string result = target.getIDprogram(ids);
            return result;
            // TODO: add assertions to method SyllabusBLLTest.getIDprogramTest(SyllabusBLL, String)
        }

        /// <summary>Test stub for getSememster(String)</summary>
        [PexMethod]
        public int getSememsterTest([PexAssumeUnderTest]SyllabusBLL target, string idprogram)
        {
            int result = target.getSememster(idprogram);
            return result;
            // TODO: add assertions to method SyllabusBLLTest.getSememsterTest(SyllabusBLL, String)
        }

        /// <summary>Test stub for loadSyllabus(String)</summary>
        [PexMethod]
        public List<Syllabus> loadSyllabusTest([PexAssumeUnderTest]SyllabusBLL target, string idprogram)
        {
            List<Syllabus> result = target.loadSyllabus(idprogram);
            return result;
            // TODO: add assertions to method SyllabusBLLTest.loadSyllabusTest(SyllabusBLL, String)
        }

        /// <summary>Test stub for loadSys(String)</summary>
        [PexMethod]
        public List<Syllabus> loadSysTest([PexAssumeUnderTest]SyllabusBLL target, string id)
        {
            List<Syllabus> result = target.loadSys(id);
            return result;
            // TODO: add assertions to method SyllabusBLLTest.loadSysTest(SyllabusBLL, String)
        }

        /// <summary>Test stub for loadpre(String)</summary>
        [PexMethod]
        public List<Syllabus> loadpreTest([PexAssumeUnderTest]SyllabusBLL target, string list1)
        {
            List<Syllabus> result = target.loadpre(list1);
            return result;
            // TODO: add assertions to method SyllabusBLLTest.loadpreTest(SyllabusBLL, String)
        }
    }
}
