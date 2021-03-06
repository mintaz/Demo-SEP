using System.Collections.Generic;
using DAL;
using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for ProgramBLL</summary>
    [TestClass]
    [PexClass(typeof(ProgramBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProgramBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public ProgramBLL ConstructorTest()
        {
            ProgramBLL target = new ProgramBLL();
            return target;
            // TODO: add assertions to method ProgramBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for CreateProgram(String, String)</summary>
        [PexMethod]
        public bool CreateProgramTest(
            [PexAssumeUnderTest]ProgramBLL target,
            string idAcc,
            string namepro
        )
        {
            bool result = target.CreateProgram(idAcc, namepro);
            return result;
            // TODO: add assertions to method ProgramBLLTest.CreateProgramTest(ProgramBLL, String, String)
        }

        /// <summary>Test stub for EditProgram(String, String, String)</summary>
        [PexMethod]
        public bool EditProgramTest(
            [PexAssumeUnderTest]ProgramBLL target,
            string id,
            string name,
            string idacc
        )
        {
            bool result = target.EditProgram(id, name, idacc);
            return result;
            // TODO: add assertions to method ProgramBLLTest.EditProgramTest(ProgramBLL, String, String, String)
        }

        /// <summary>Test stub for Load()</summary>
        [PexMethod]
        public List<Program> LoadTest([PexAssumeUnderTest]ProgramBLL target)
        {
            List<Program> result = target.Load();
            return result;
            // TODO: add assertions to method ProgramBLLTest.LoadTest(ProgramBLL)
        }

        /// <summary>Test stub for LoadProgram(String)</summary>
        [PexMethod]
        public List<Program> LoadProgramTest([PexAssumeUnderTest]ProgramBLL target, string id)
        {
            List<Program> result = target.LoadProgram(id);
            return result;
            // TODO: add assertions to method ProgramBLLTest.LoadProgramTest(ProgramBLL, String)
        }

        /// <summary>Test stub for UpdateProgram(String, String, String, String, String, String, String, String, Int32, Int32, Int32)</summary>
        [PexMethod]
        public bool UpdateProgramTest(
            [PexAssumeUnderTest]ProgramBLL target,
            string id,
            string programlevel,
            string programbranch,
            string programtype,
            string programtime,
            string programactor,
            string programvolume,
            string programprocess,
            int programpoint,
            int programsem,
            int programmark
        )
        {
            bool result = target.UpdateProgram(id, programlevel, programbranch, programtype, programtime,
                                               programactor, programvolume, programprocess, programpoint, programsem, programmark);
            return result;
            // TODO: add assertions to method ProgramBLLTest.UpdateProgramTest(ProgramBLL, String, String, String, String, String, String, String, String, Int32, Int32, Int32)
        }

        /// <summary>Test stub for createID()</summary>
        [PexMethod]
        public string createIDTest([PexAssumeUnderTest]ProgramBLL target)
        {
            string result = target.createID();
            return result;
            // TODO: add assertions to method ProgramBLLTest.createIDTest(ProgramBLL)
        }
    }
}
