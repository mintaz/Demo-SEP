using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for ResetBLL</summary>
    [TestClass]
    [PexClass(typeof(ResetBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ResetBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public ResetBLL ConstructorTest()
        {
            ResetBLL target = new ResetBLL();
            return target;
            // TODO: add assertions to method ResetBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for successUpdate(String, String)</summary>
        [PexMethod]
        public bool successUpdateTest(
            [PexAssumeUnderTest]ResetBLL target,
            string user,
            string pass
        )
        {
            bool result = target.successUpdate(user, pass);
            return result;
            // TODO: add assertions to method ResetBLLTest.successUpdateTest(ResetBLL, String, String)
        }
    }
}
