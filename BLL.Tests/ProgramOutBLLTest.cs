using System.Collections.Generic;
using DAL;
using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for ProgramOutBLL</summary>
    [TestClass]
    [PexClass(typeof(ProgramOutBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProgramOutBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public ProgramOutBLL ConstructorTest()
        {
            ProgramOutBLL target = new ProgramOutBLL();
            return target;
            // TODO: add assertions to method ProgramOutBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for AddProOut(String, String, Int32, String)</summary>
        [PexMethod]
        public bool AddProOutTest(
            [PexAssumeUnderTest]ProgramOutBLL target,
            string idp,
            string no,
            int type,
            string content
        )
        {
            bool result = target.AddProOut(idp, no, type, content);
            return result;
            // TODO: add assertions to method ProgramOutBLLTest.AddProOutTest(ProgramOutBLL, String, String, Int32, String)
        }

        /// <summary>Test stub for EditProOut(String, String, Int32, String)</summary>
        [PexMethod]
        public bool EditProOutTest(
            [PexAssumeUnderTest]ProgramOutBLL target,
            string id,
            string no,
            int type,
            string content
        )
        {
            bool result = target.EditProOut(id, no, type, content);
            return result;
            // TODO: add assertions to method ProgramOutBLLTest.EditProOutTest(ProgramOutBLL, String, String, Int32, String)
        }

        /// <summary>Test stub for LoadOutcomes(String)</summary>
        [PexMethod]
        public List<ProgramOutcome> LoadOutcomesTest([PexAssumeUnderTest]ProgramOutBLL target, string idpout)
        {
            List<ProgramOutcome> result = target.LoadOutcomes(idpout);
            return result;
            // TODO: add assertions to method ProgramOutBLLTest.LoadOutcomesTest(ProgramOutBLL, String)
        }

        /// <summary>Test stub for LoadPOutcomes(String)</summary>
        [PexMethod]
        public List<ProgramOutcome> LoadPOutcomesTest([PexAssumeUnderTest]ProgramOutBLL target, string idp)
        {
            List<ProgramOutcome> result = target.LoadPOutcomes(idp);
            return result;
            // TODO: add assertions to method ProgramOutBLLTest.LoadPOutcomesTest(ProgramOutBLL, String)
        }

        /// <summary>Test stub for createID()</summary>
        [PexMethod]
        public string createIDTest([PexAssumeUnderTest]ProgramOutBLL target)
        {
            string result = target.createID();
            return result;
            // TODO: add assertions to method ProgramOutBLLTest.createIDTest(ProgramOutBLL)
        }
    }
}
