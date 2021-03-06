using System;
using BLL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for LoginBLL</summary>
    [TestClass]
    [PexClass(typeof(LoginBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class LoginBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public LoginBLL ConstructorTest()
        {
            LoginBLL target = new LoginBLL();
            return target;
            // TODO: add assertions to method LoginBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for getID(String)</summary>
        [PexMethod]
        public string getIDTest([PexAssumeUnderTest]LoginBLL target, string user)
        {
            string result = target.getID(user);
            return result;
            // TODO: add assertions to method LoginBLLTest.getIDTest(LoginBLL, String)
        }

        /// <summary>Test stub for getnameprogram(String)</summary>
        [PexMethod]
        public string getnameprogramTest([PexAssumeUnderTest]LoginBLL target, string id)
        {
            string result = target.getnameprogram(id);
            return result;
            // TODO: add assertions to method LoginBLLTest.getnameprogramTest(LoginBLL, String)
        }

        /// <summary>Test stub for getnamesyllabus(String)</summary>
        [PexMethod]
        public string getnamesyllabusTest([PexAssumeUnderTest]LoginBLL target, string id)
        {
            string result = target.getnamesyllabus(id);
            return result;
            // TODO: add assertions to method LoginBLLTest.getnamesyllabusTest(LoginBLL, String)
        }

        /// <summary>Test stub for isActive(String)</summary>
        [PexMethod]
        public bool isActiveTest([PexAssumeUnderTest]LoginBLL target, string user)
        {
            bool result = target.isActive(user);
            return result;
            // TODO: add assertions to method LoginBLLTest.isActiveTest(LoginBLL, String)
        }

        /// <summary>Test stub for isAdmin(String)</summary>
        [PexMethod]
        public bool isAdminTest([PexAssumeUnderTest]LoginBLL target, string user)
        {
            bool result = target.isAdmin(user);
            return result;
            // TODO: add assertions to method LoginBLLTest.isAdminTest(LoginBLL, String)
        }

        /// <summary>Test stub for isCount(String)</summary>
        [PexMethod]
        public bool isCountTest([PexAssumeUnderTest]LoginBLL target, string id)
        {
            bool result = target.isCount(id);
            return result;
            // TODO: add assertions to method LoginBLLTest.isCountTest(LoginBLL, String)
        }

        /// <summary>Test stub for isvaildAccount(String)</summary>
        [PexMethod]
        public bool isvaildAccountTest([PexAssumeUnderTest]LoginBLL target, string user)
        {
            bool result = target.isvaildAccount(user);
            return result;
            // TODO: add assertions to method LoginBLLTest.isvaildAccountTest(LoginBLL, String)
        }

        /// <summary>Test stub for isvaildEmail(String)</summary>
        [PexMethod]
        public bool isvaildEmailTest([PexAssumeUnderTest]LoginBLL target, string email)
        {
            bool result = target.isvaildEmail(email);
            return result;
            // TODO: add assertions to method LoginBLLTest.isvaildEmailTest(LoginBLL, String)
        }

        /// <summary>Test stub for isvaildPass(String, String)</summary>
        [PexMethod]
        public bool isvaildPassTest(
            [PexAssumeUnderTest]LoginBLL target,
            string user,
            string pass
        )
        {
            bool result = target.isvaildPass(user, pass);
            return result;
            // TODO: add assertions to method LoginBLLTest.isvaildPassTest(LoginBLL, String, String)
        }
    }
}
