using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CORE.Service.IF;
using CORE.Website.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CORE.Website.Areas.Admin.Controllers
{
    public class CustomerController : AdminController
    {
        private readonly IConfiguration _configuration;
        private readonly ICustomerService _customerService;
        private readonly IViewEnginerService _viewEngineService;
        public CustomerController(IConfiguration configuaration, ICustomerService customerService, IViewEnginerService viewEngineService)
        {
            _configuration = configuaration;
            _customerService = customerService;
            _viewEngineService = viewEngineService;
        }

        public IActionResult GetCustomers()
        {
            var model = _customerService.GetCustomers();
            return View(model);
        }
    }
}
