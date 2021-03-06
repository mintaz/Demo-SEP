using DAL;
using System.Collections.Generic;
using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for MappingBLL</summary>
    [TestClass]
    [PexClass(typeof(MappingBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MappingBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public MappingBLL ConstructorTest()
        {
            MappingBLL target = new MappingBLL();
            return target;
            // TODO: add assertions to method MappingBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for AddMap(String, String, String)</summary>
        [PexMethod]
        public bool AddMapTest(
            [PexAssumeUnderTest]MappingBLL target,
            string idS,
            string sys,
            string program
        )
        {
            bool result = target.AddMap(idS, sys, program);
            return result;
            // TODO: add assertions to method MappingBLLTest.AddMapTest(MappingBLL, String, String, String)
        }

        /// <summary>Test stub for ChangePro(String, String)</summary>
        [PexMethod]
        public bool ChangeProTest(
            [PexAssumeUnderTest]MappingBLL target,
            string sts,
            string stp
        )
        {
            bool result = target.ChangePro(sts, stp);
            return result;
            // TODO: add assertions to method MappingBLLTest.ChangeProTest(MappingBLL, String, String)
        }

        /// <summary>Test stub for DelMap(String)</summary>
        [PexMethod]
        public bool DelMapTest([PexAssumeUnderTest]MappingBLL target, string idS)
        {
            bool result = target.DelMap(idS);
            return result;
            // TODO: add assertions to method MappingBLLTest.DelMapTest(MappingBLL, String)
        }

        /// <summary>Test stub for DelMapfromSyOut(String)</summary>
        [PexMethod]
        public void DelMapfromSyOutTest([PexAssumeUnderTest]MappingBLL target, string idOut)
        {
            target.DelMapfromSyOut(idOut);
            // TODO: add assertions to method MappingBLLTest.DelMapfromSyOutTest(MappingBLL, String)
        }

        /// <summary>Test stub for UpdateMethod(String, String, String, String, String, Int32, Int32, Int32, Int32)</summary>
        [PexMethod]
        public bool UpdateMethodTest(
            [PexAssumeUnderTest]MappingBLL target,
            string idmap,
            string method,
            string p1,
            string p2,
            string p3,
            int per1,
            int per2,
            int per3,
            int des
        )
        {
            bool result = target.UpdateMethod(idmap, method, p1, p2, p3, per1, per2, per3, des);
            return result;
            // TODO: add assertions to method MappingBLLTest.UpdateMethodTest(MappingBLL, String, String, String, String, String, Int32, Int32, Int32, Int32)
        }

        /// <summary>Test stub for checkexistid(String)</summary>
        [PexMethod]
        public bool checkexistidTest([PexAssumeUnderTest]MappingBLL target, string sts)
        {
            bool result = target.checkexistid(sts);
            return result;
            // TODO: add assertions to method MappingBLLTest.checkexistidTest(MappingBLL, String)
        }

        /// <summary>Test stub for createMapID()</summary>
        [PexMethod]
        public string createMapIDTest([PexAssumeUnderTest]MappingBLL target)
        {
            string result = target.createMapID();
            return result;
            // TODO: add assertions to method MappingBLLTest.createMapIDTest(MappingBLL)
        }

        /// <summary>Test stub for createString(List`1&lt;String&gt;)</summary>
        [PexMethod]
        public string createStringTest([PexAssumeUnderTest]MappingBLL target, List<string> listid)
        {
            string result = target.createString(listid);
            return result;
            // TODO: add assertions to method MappingBLLTest.createStringTest(MappingBLL, List`1<String>)
        }

        /// <summary>Test stub for getCount(String)</summary>
        [PexMethod]
        public int getCountTest([PexAssumeUnderTest]MappingBLL target, string ids)
        {
            int result = target.getCount(ids);
            return result;
            // TODO: add assertions to method MappingBLLTest.getCountTest(MappingBLL, String)
        }

        /// <summary>Test stub for listmap(String)</summary>
        [PexMethod]
        public List<Mapping> listmapTest([PexAssumeUnderTest]MappingBLL target, string idS)
        {
            List<Mapping> result = target.listmap(idS);
            return result;
            // TODO: add assertions to method MappingBLLTest.listmapTest(MappingBLL, String)
        }

        /// <summary>Test stub for loadPrOut(String)</summary>
        [PexMethod]
        public List<ProgramOutcome> loadPrOutTest([PexAssumeUnderTest]MappingBLL target, string idP)
        {
            List<ProgramOutcome> result = target.loadPrOut(idP);
            return result;
            // TODO: add assertions to method MappingBLLTest.loadPrOutTest(MappingBLL, String)
        }

        /// <summary>Test stub for loadSyOut(String)</summary>
        [PexMethod]
        public List<SyllabusOutcome> loadSyOutTest([PexAssumeUnderTest]MappingBLL target, string idS)
        {
            List<SyllabusOutcome> result = target.loadSyOut(idS);
            return result;
            // TODO: add assertions to method MappingBLLTest.loadSyOutTest(MappingBLL, String)
        }

        /// <summary>Test stub for loadcheckedlist(String)</summary>
        [PexMethod]
        public List<string> loadcheckedlistTest([PexAssumeUnderTest]MappingBLL target, string line)
        {
            List<string> result = target.loadcheckedlist(line);
            return result;
            // TODO: add assertions to method MappingBLLTest.loadcheckedlistTest(MappingBLL, String)
        }

        /// <summary>Test stub for loadmap(String)</summary>
        [PexMethod]
        public string loadmapTest([PexAssumeUnderTest]MappingBLL target, string sts)
        {
            string result = target.loadmap(sts);
            return result;
            // TODO: add assertions to method MappingBLLTest.loadmapTest(MappingBLL, String)
        }

        /// <summary>Test stub for singlemap(String)</summary>
        [PexMethod]
        public List<Mapping> singlemapTest([PexAssumeUnderTest]MappingBLL target, string idmap)
        {
            List<Mapping> result = target.singlemap(idmap);
            return result;
            // TODO: add assertions to method MappingBLLTest.singlemapTest(MappingBLL, String)
        }
    }
}
