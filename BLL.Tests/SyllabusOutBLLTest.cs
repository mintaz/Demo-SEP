using System.Collections.Generic;
using DAL;
using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for SyllabusOutBLL</summary>
    [TestClass]
    [PexClass(typeof(SyllabusOutBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SyllabusOutBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public SyllabusOutBLL ConstructorTest()
        {
            SyllabusOutBLL target = new SyllabusOutBLL();
            return target;
            // TODO: add assertions to method SyllabusOutBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for AddOut(String, String, String)</summary>
        [PexMethod]
        public bool AddOutTest(
            [PexAssumeUnderTest]SyllabusOutBLL target,
            string ids,
            string no,
            string content
        )
        {
            bool result = target.AddOut(ids, no, content);
            return result;
            // TODO: add assertions to method SyllabusOutBLLTest.AddOutTest(SyllabusOutBLL, String, String, String)
        }

        /// <summary>Test stub for DelOut(String)</summary>
        [PexMethod]
        public bool DelOutTest([PexAssumeUnderTest]SyllabusOutBLL target, string id)
        {
            bool result = target.DelOut(id);
            return result;
            // TODO: add assertions to method SyllabusOutBLLTest.DelOutTest(SyllabusOutBLL, String)
        }

        /// <summary>Test stub for EditOut(String, String, String)</summary>
        [PexMethod]
        public bool EditOutTest(
            [PexAssumeUnderTest]SyllabusOutBLL target,
            string id,
            string no,
            string content
        )
        {
            bool result = target.EditOut(id, no, content);
            return result;
            // TODO: add assertions to method SyllabusOutBLLTest.EditOutTest(SyllabusOutBLL, String, String, String)
        }

        /// <summary>Test stub for createID()</summary>
        [PexMethod]
        public string createIDTest([PexAssumeUnderTest]SyllabusOutBLL target)
        {
            string result = target.createID();
            return result;
            // TODO: add assertions to method SyllabusOutBLLTest.createIDTest(SyllabusOutBLL)
        }

        /// <summary>Test stub for getCount(String)</summary>
        [PexMethod]
        public int getCountTest([PexAssumeUnderTest]SyllabusOutBLL target, string ids)
        {
            int result = target.getCount(ids);
            return result;
            // TODO: add assertions to method SyllabusOutBLLTest.getCountTest(SyllabusOutBLL, String)
        }

        /// <summary>Test stub for loadlistout(String)</summary>
        [PexMethod]
        public List<SyllabusOutcome> loadlistoutTest([PexAssumeUnderTest]SyllabusOutBLL target, string id)
        {
            List<SyllabusOutcome> result = target.loadlistout(id);
            return result;
            // TODO: add assertions to method SyllabusOutBLLTest.loadlistoutTest(SyllabusOutBLL, String)
        }

        /// <summary>Test stub for loadout(String)</summary>
        [PexMethod]
        public List<SyllabusOutcome> loadoutTest([PexAssumeUnderTest]SyllabusOutBLL target, string idout)
        {
            List<SyllabusOutcome> result = target.loadout(idout);
            return result;
            // TODO: add assertions to method SyllabusOutBLLTest.loadoutTest(SyllabusOutBLL, String)
        }
    }
}
