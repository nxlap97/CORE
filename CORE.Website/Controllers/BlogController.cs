using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CORE.Website.Controllers
{
    public class BlogController : Controller
    {
        [Route("blogs.html")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{alias}-b.{id}.html", Name = "ProductDetail")]
        public IActionResult Details(string id)
        {
            return View();
        }
    }
}
