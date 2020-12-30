using CORE.Data.Infrastructor;
using CORE.Domain.Enums;
using CORE.Domain.Models;
using CORE.Service.IF;
using CORE.Service.Model;
using CORE.Utility.StringHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CORE.Service.EF
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer, string> _customerService;
        private readonly IReadOnlyRepository _readOnlyRepository;
        public CustomerService(IRepository<Customer, string> customerService, IReadOnlyRepository readOnlyRepository)
        {
            _customerService = customerService;
            _readOnlyRepository = readOnlyRepository;
        }
        public ResultStatus<Customer> CheckSignIn(string userName, string password)
        {

            var customer = _customerService.FindAll(x => x.UserName == userName.Trim()).FirstOrDefault();
            var result = new ResultStatus<Customer>() { Status = true, Message = "Đăng nhập thành công", Object = customer };

            if (customer == null)
                return new ResultStatus<Customer>() { Status = false, Message = "Tài khoản không tồn tại trong hệ thống" };

            if (customer.Password != password)
                return new ResultStatus<Customer>() { Status = false, Message = "Mật khẩu không đúng vui lòng kiểm tra lại" };

            switch (customer.Status)
            {
                case CustomerStatus.Register:
                    return new ResultStatus<Customer>() { Status = false, Message = "Tài khoản chưa kích hoạt vui lòng liên hệ với admin để được kích hoạt tài khoản" };
                case CustomerStatus.Blocked:
                    return new ResultStatus<Customer>() { Status = false, Message = "Tài khoản này đã bị khóa." };
                case CustomerStatus.Remove:
                    return new ResultStatus<Customer>() { Status = false, Message = "Tài khoản này đã bị xóa khỏi hệ thống." };
            }

            return result;
        }

        public List<CustomerModel> GetCustomers()
        {
            var json = _readOnlyRepository.GetListNoneFilter(StoreProduceHelper.SP_GetCustomers);
            var model = JsonConvert.DeserializeObject<List<CustomerModel>>(json);
            return model;
        }
    }
}
