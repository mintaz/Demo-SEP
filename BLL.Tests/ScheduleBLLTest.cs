using System.Collections.Generic;
using DAL;
using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for ScheduleBLL</summary>
    [TestClass]
    [PexClass(typeof(ScheduleBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ScheduleBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public ScheduleBLL ConstructorTest()
        {
            ScheduleBLL target = new ScheduleBLL();
            return target;
            // TODO: add assertions to method ScheduleBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for AddSche(String, DateTime, Int32, String, String, String, Boolean)</summary>
        [PexMethod]
        public bool AddScheTest(
            [PexAssumeUnderTest]ScheduleBLL target,
            string idS,
            DateTime date,
            int number,
            string content,
            string acitve,
            string doc,
            bool mid
        )
        {
            bool result = target.AddSche(idS, date, number, content, acitve, doc, mid);
            return result;
            // TODO: add assertions to method ScheduleBLLTest.AddScheTest(ScheduleBLL, String, DateTime, Int32, String, String, String, Boolean)
        }

        /// <summary>Test stub for DelSche(String)</summary>
        [PexMethod]
        public bool DelScheTest([PexAssumeUnderTest]ScheduleBLL target, string id)
        {
            bool result = target.DelSche(id);
            return result;
            // TODO: add assertions to method ScheduleBLLTest.DelScheTest(ScheduleBLL, String)
        }

        /// <summary>Test stub for EditSche(String, DateTime, Int32, String, String, String, Boolean)</summary>
        [PexMethod]
        public bool EditScheTest(
            [PexAssumeUnderTest]ScheduleBLL target,
            string id,
            DateTime date,
            int number,
            string content,
            string acitve,
            string doc,
            bool mid
        )
        {
            bool result = target.EditSche(id, date, number, content, acitve, doc, mid);
            return result;
            // TODO: add assertions to method ScheduleBLLTest.EditScheTest(ScheduleBLL, String, DateTime, Int32, String, String, String, Boolean)
        }

        /// <summary>Test stub for ListSche(String)</summary>
        [PexMethod]
        public List<SyllabusSchedule> ListScheTest([PexAssumeUnderTest]ScheduleBLL target, string idS)
        {
            List<SyllabusSchedule> result = target.ListSche(idS);
            return result;
            // TODO: add assertions to method ScheduleBLLTest.ListScheTest(ScheduleBLL, String)
        }

        /// <summary>Test stub for SingleSche(String)</summary>
        [PexMethod]
        public List<SyllabusSchedule> SingleScheTest([PexAssumeUnderTest]ScheduleBLL target, string id)
        {
            List<SyllabusSchedule> result = target.SingleSche(id);
            return result;
            // TODO: add assertions to method ScheduleBLLTest.SingleScheTest(ScheduleBLL, String)
        }

        /// <summary>Test stub for check(String, Int32)</summary>
        [PexMethod]
        public bool checkTest(
            [PexAssumeUnderTest]ScheduleBLL target,
            string idS,
            int period
        )
        {
            bool result = target.check(idS, period);
            return result;
            // TODO: add assertions to method ScheduleBLLTest.checkTest(ScheduleBLL, String, Int32)
        }

        /// <summary>Test stub for getsto(String)</summary>
        [PexMethod]
        public string getstoTest([PexAssumeUnderTest]ScheduleBLL target, string idS)
        {
            string result = target.getsto(idS);
            return result;
            // TODO: add assertions to method ScheduleBLLTest.getstoTest(ScheduleBLL, String)
        }

        /// <summary>Test stub for isEdit(String, Int32)</summary>
        [PexMethod]
        public bool isEditTest(
            [PexAssumeUnderTest]ScheduleBLL target,
            string id,
            int number
        )
        {
            bool result = target.isEdit(id, number);
            return result;
            // TODO: add assertions to method ScheduleBLLTest.isEditTest(ScheduleBLL, String, Int32)
        }
    }
}
