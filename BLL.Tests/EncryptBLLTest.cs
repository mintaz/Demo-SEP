using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for EncryptBLL</summary>
    [TestClass]
    [PexClass(typeof(EncryptBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EncryptBLLTest
    {

        /// <summary>Test stub for EncodeSHA1(String)</summary>
        [PexMethod]
        public string EncodeSHA1Test([PexAssumeUnderTest]EncryptBLL target, string pass)
        {
            string result = target.EncodeSHA1(pass);
            return result;
            // TODO: add assertions to method EncryptBLLTest.EncodeSHA1Test(EncryptBLL, String)
        }
    }
}
