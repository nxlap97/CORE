using CORE.Domain.Models;
using CORE.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.IF
{
    public interface ICustomerService
    {
        #region MyRegion

        #endregion
        ResultStatus<Customer> CheckSignIn(string userName, string password);
        List<CustomerModel> GetCustomers();
    }
}
