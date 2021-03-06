using BLL;
using System;
using Microsoft.Pex.Framework;

namespace BLL
{
    /// <summary>A factory for BLL.AccountBLL instances</summary>
    public static partial class AccountBLLFactory
    {
        /// <summary>A factory for BLL.AccountBLL instances</summary>
        [PexFactoryMethod(typeof(AccountBLL))]
        public static AccountBLL Create()
        {
            AccountBLL accountBLL = new AccountBLL();
            return accountBLL;

            // TODO: Edit factory method of AccountBLL
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
