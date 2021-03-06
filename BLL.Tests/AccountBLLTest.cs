// <copyright file="AccountBLLTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using BLL;
using DAL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    /// <summary>This class contains parameterized unit tests for AccountBLL</summary>
    [PexClass(typeof(AccountBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AccountBLLTest
    {
        /// <summary>Test stub for AddAccount(String, String, Boolean, Boolean)</summary>
        [PexMethod]
        public bool AddAccountTest(
            [PexAssumeUnderTest]AccountBLL target,
            string user,
            string name,
            bool isadmin,
            bool active
        )
        {
            bool result = target.AddAccount(user, name, isadmin, active);
            return result;
            // TODO: add assertions to method AccountBLLTest.AddAccountTest(AccountBLL, String, String, Boolean, Boolean)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public AccountBLL ConstructorTest()
        {
            AccountBLL target = new AccountBLL();
            return target;
            // TODO: add assertions to method AccountBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for DeleteAccount(String)</summary>
        [PexMethod]
        public bool DeleteAccountTest([PexAssumeUnderTest]AccountBLL target, string idd)
        {
            bool result = target.DeleteAccount(idd);
            return result;
            // TODO: add assertions to method AccountBLLTest.DeleteAccountTest(AccountBLL, String)
        }

        /// <summary>Test stub for EditAccount(String, String, String, Boolean, Boolean)</summary>
        [PexMethod]
        public bool EditAccountTest(
            [PexAssumeUnderTest]AccountBLL target,
            string id,
            string user,
            string name,
            bool isadmin,
            bool active
        )
        {
            bool result = target.EditAccount(id, user, name, isadmin, active);
            return result;
            // TODO: add assertions to method AccountBLLTest.EditAccountTest(AccountBLL, String, String, String, Boolean, Boolean)
        }

        /// <summary>Test stub for LoadAccount()</summary>
        [PexMethod]
        public List<Account> LoadAccountTest([PexAssumeUnderTest]AccountBLL target)
        {
            List<Account> result = target.LoadAccount();
            return result;
            // TODO: add assertions to method AccountBLLTest.LoadAccountTest(AccountBLL)
        }

        /// <summary>Test stub for LoadUser(String)</summary>
        [PexMethod]
        public List<Account> LoadUserTest([PexAssumeUnderTest]AccountBLL target, string id)
        {
            List<Account> result = target.LoadUser(id);
            return result;
            // TODO: add assertions to method AccountBLLTest.LoadUserTest(AccountBLL, String)
        }

        /// <summary>Test stub for createID()</summary>
        [PexMethod]
        public string createIDTest([PexAssumeUnderTest]AccountBLL target)
        {
            string result = target.createID();
            return result;
            // TODO: add assertions to method AccountBLLTest.createIDTest(AccountBLL)
        }
    }
}
