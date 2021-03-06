using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for CompareBLL</summary>
    [TestClass]
    [PexClass(typeof(CompareBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CompareBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public CompareBLL ConstructorTest()
        {
            CompareBLL target = new CompareBLL();
            return target;
            // TODO: add assertions to method CompareBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for Compare2string(String, String)</summary>
        [PexMethod]
        public bool Compare2stringTest(
            [PexAssumeUnderTest]CompareBLL target,
            string oldstring,
            string newstring
        )
        {
            bool result = target.Compare2string(oldstring, newstring);
            return result;
            // TODO: add assertions to method CompareBLLTest.Compare2stringTest(CompareBLL, String, String)
        }

        /// <summary>Test stub for changeName(String, String)</summary>
        [PexMethod]
        public bool changeNameTest(
            [PexAssumeUnderTest]CompareBLL target,
            string id,
            string name
        )
        {
            bool result = target.changeName(id, name);
            return result;
            // TODO: add assertions to method CompareBLLTest.changeNameTest(CompareBLL, String, String)
        }

        /// <summary>Test stub for changepass(String, String)</summary>
        [PexMethod(MaxConditions = 1000)]
        public bool changepassTest(
            [PexAssumeUnderTest]CompareBLL target,
            string id,
            string pass
        )
        {
            bool result = target.changepass(id, pass);
            return result;
            // TODO: add assertions to method CompareBLLTest.changepassTest(CompareBLL, String, String)
        }
    }
}
