﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE.Website.Areas.Admin.Controllers.Components
{
    public class NavigaBarAdminViewComponent : ViewComponent
    {
        public NavigaBarAdminViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
