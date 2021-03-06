using System.Collections.Generic;
using DAL;
using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for SyllabusObjBLL</summary>
    [TestClass]
    [PexClass(typeof(SyllabusObjBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SyllabusObjBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public SyllabusObjBLL ConstructorTest()
        {
            SyllabusObjBLL target = new SyllabusObjBLL();
            return target;
            // TODO: add assertions to method SyllabusObjBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for AddObj(String, String)</summary>
        [PexMethod]
        public bool AddObjTest(
            [PexAssumeUnderTest]SyllabusObjBLL target,
            string ids,
            string content
        )
        {
            bool result = target.AddObj(ids, content);
            return result;
            // TODO: add assertions to method SyllabusObjBLLTest.AddObjTest(SyllabusObjBLL, String, String)
        }

        /// <summary>Test stub for DelObj(String)</summary>
        [PexMethod]
        public bool DelObjTest([PexAssumeUnderTest]SyllabusObjBLL target, string id)
        {
            bool result = target.DelObj(id);
            return result;
            // TODO: add assertions to method SyllabusObjBLLTest.DelObjTest(SyllabusObjBLL, String)
        }

        /// <summary>Test stub for EditObj(String, String)</summary>
        [PexMethod]
        public bool EditObjTest(
            [PexAssumeUnderTest]SyllabusObjBLL target,
            string id,
            string content
        )
        {
            bool result = target.EditObj(id, content);
            return result;
            // TODO: add assertions to method SyllabusObjBLLTest.EditObjTest(SyllabusObjBLL, String, String)
        }

        /// <summary>Test stub for createID()</summary>
        [PexMethod]
        public string createIDTest([PexAssumeUnderTest]SyllabusObjBLL target)
        {
            string result = target.createID();
            return result;
            // TODO: add assertions to method SyllabusObjBLLTest.createIDTest(SyllabusObjBLL)
        }

        /// <summary>Test stub for loadlistobj(String)</summary>
        [PexMethod]
        public List<SyllabusObjective> loadlistobjTest([PexAssumeUnderTest]SyllabusObjBLL target, string id)
        {
            List<SyllabusObjective> result = target.loadlistobj(id);
            return result;
            // TODO: add assertions to method SyllabusObjBLLTest.loadlistobjTest(SyllabusObjBLL, String)
        }

        /// <summary>Test stub for loadobj(String)</summary>
        [PexMethod]
        public List<SyllabusObjective> loadobjTest([PexAssumeUnderTest]SyllabusObjBLL target, string idobj)
        {
            List<SyllabusObjective> result = target.loadobj(idobj);
            return result;
            // TODO: add assertions to method SyllabusObjBLLTest.loadobjTest(SyllabusObjBLL, String)
        }
    }
}
