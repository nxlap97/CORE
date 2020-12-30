using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CORE.Service.IF;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace CORE.Website.Areas.Admin.Controllers
{
    
    public class HomeController : AdminController
    {
        private readonly IBlogService _blogService;
        public HomeController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult Index()
        {
            var a = _blogService.GetAll();

            return View();
        }
    }
}
