﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AQS.BookingMVC.Components.Common
{
    public class FooterBlogBoxViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("FooterBlogBox");
        }
    }
}
