using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CORE.Website.Areas.Admin.Controllers
{
    public class SettingController : AdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
