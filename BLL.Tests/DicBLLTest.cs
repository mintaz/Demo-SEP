using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for DicBLL</summary>
    [TestClass]
    [PexClass(typeof(DicBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DicBLLTest
    {

        /// <summary>Test stub for defaultPass()</summary>
        [PexMethod]
        public string defaultPassTest([PexAssumeUnderTest]DicBLL target)
        {
            string result = target.defaultPass();
            return result;
            // TODO: add assertions to method DicBLLTest.defaultPassTest(DicBLL)
        }

        /// <summary>Test stub for errorAccountMessage(String)</summary>
        [PexMethod]
        public string errorAccountMessageTest([PexAssumeUnderTest]DicBLL target, string error)
        {
            string result = target.errorAccountMessage(error);
            return result;
            // TODO: add assertions to method DicBLLTest.errorAccountMessageTest(DicBLL, String)
        }

        /// <summary>Test stub for errorChangeMessage(String)</summary>
        [PexMethod]
        public string errorChangeMessageTest([PexAssumeUnderTest]DicBLL target, string er)
        {
            string result = target.errorChangeMessage(er);
            return result;
            // TODO: add assertions to method DicBLLTest.errorChangeMessageTest(DicBLL, String)
        }

        /// <summary>Test stub for errorCreateProgram(String)</summary>
        [PexMethod]
        public string errorCreateProgramTest([PexAssumeUnderTest]DicBLL target, string er)
        {
            string result = target.errorCreateProgram(er);
            return result;
            // TODO: add assertions to method DicBLLTest.errorCreateProgramTest(DicBLL, String)
        }

        /// <summary>Test stub for errorProOut(String)</summary>
        [PexMethod]
        public string errorProOutTest([PexAssumeUnderTest]DicBLL target, string er)
        {
            string result = target.errorProOut(er);
            return result;
            // TODO: add assertions to method DicBLLTest.errorProOutTest(DicBLL, String)
        }

        /// <summary>Test stub for errorResetMessage(String)</summary>
        [PexMethod]
        public string errorResetMessageTest([PexAssumeUnderTest]DicBLL target, string error)
        {
            string result = target.errorResetMessage(error);
            return result;
            // TODO: add assertions to method DicBLLTest.errorResetMessageTest(DicBLL, String)
        }

        /// <summary>Test stub for errorloginMessage(String)</summary>
        [PexMethod]
        public string errorloginMessageTest([PexAssumeUnderTest]DicBLL target, string error)
        {
            string result = target.errorloginMessage(error);
            return result;
            // TODO: add assertions to method DicBLLTest.errorloginMessageTest(DicBLL, String)
        }

        /// <summary>Test stub for errormethod(String)</summary>
        [PexMethod]
        public string errormethodTest([PexAssumeUnderTest]DicBLL target, string mes)
        {
            string result = target.errormethod(mes);
            return result;
            // TODO: add assertions to method DicBLLTest.errormethodTest(DicBLL, String)
        }

        /// <summary>Test stub for schedule(String)</summary>
        [PexMethod]
        public string scheduleTest([PexAssumeUnderTest]DicBLL target, string mes)
        {
            string result = target.schedule(mes);
            return result;
            // TODO: add assertions to method DicBLLTest.scheduleTest(DicBLL, String)
        }

        /// <summary>Test stub for successAccountMessage(String)</summary>
        [PexMethod]
        public string successAccountMessageTest([PexAssumeUnderTest]DicBLL target, string sc)
        {
            string result = target.successAccountMessage(sc);
            return result;
            // TODO: add assertions to method DicBLLTest.successAccountMessageTest(DicBLL, String)
        }

        /// <summary>Test stub for successChangeMessage(String)</summary>
        [PexMethod]
        public string successChangeMessageTest([PexAssumeUnderTest]DicBLL target, string sc)
        {
            string result = target.successChangeMessage(sc);
            return result;
            // TODO: add assertions to method DicBLLTest.successChangeMessageTest(DicBLL, String)
        }

        /// <summary>Test stub for successCreateProgram(String)</summary>
        [PexMethod]
        public string successCreateProgramTest([PexAssumeUnderTest]DicBLL target, string sc)
        {
            string result = target.successCreateProgram(sc);
            return result;
            // TODO: add assertions to method DicBLLTest.successCreateProgramTest(DicBLL, String)
        }

        /// <summary>Test stub for successProgramOut(String)</summary>
        [PexMethod]
        public string successProgramOutTest([PexAssumeUnderTest]DicBLL target, string sc)
        {
            string result = target.successProgramOut(sc);
            return result;
            // TODO: add assertions to method DicBLLTest.successProgramOutTest(DicBLL, String)
        }

        /// <summary>Test stub for successResetMessage()</summary>
        [PexMethod]
        public string successResetMessageTest([PexAssumeUnderTest]DicBLL target)
        {
            string result = target.successResetMessage();
            return result;
            // TODO: add assertions to method DicBLLTest.successResetMessageTest(DicBLL)
        }

        /// <summary>Test stub for successcreatsyllabus(String)</summary>
        [PexMethod]
        public string successcreatsyllabusTest([PexAssumeUnderTest]DicBLL target, string sc)
        {
            string result = target.successcreatsyllabus(sc);
            return result;
            // TODO: add assertions to method DicBLLTest.successcreatsyllabusTest(DicBLL, String)
        }

        /// <summary>Test stub for successupdateprogram(String)</summary>
        [PexMethod]
        public string successupdateprogramTest([PexAssumeUnderTest]DicBLL target, string sc)
        {
            string result = target.successupdateprogram(sc);
            return result;
            // TODO: add assertions to method DicBLLTest.successupdateprogramTest(DicBLL, String)
        }

        /// <summary>Test stub for syllabusinfo(String)</summary>
        [PexMethod]
        public string syllabusinfoTest([PexAssumeUnderTest]DicBLL target, string mes)
        {
            string result = target.syllabusinfo(mes);
            return result;
            // TODO: add assertions to method DicBLLTest.syllabusinfoTest(DicBLL, String)
        }

        /// <summary>Test stub for sysllabusobj(String)</summary>
        [PexMethod]
        public string sysllabusobjTest([PexAssumeUnderTest]DicBLL target, string mes)
        {
            string result = target.sysllabusobj(mes);
            return result;
            // TODO: add assertions to method DicBLLTest.sysllabusobjTest(DicBLL, String)
        }

        /// <summary>Test stub for sysllabusout(String)</summary>
        [PexMethod]
        public string sysllabusoutTest([PexAssumeUnderTest]DicBLL target, string mes)
        {
            string result = target.sysllabusout(mes);
            return result;
            // TODO: add assertions to method DicBLLTest.sysllabusoutTest(DicBLL, String)
        }
    }
}
