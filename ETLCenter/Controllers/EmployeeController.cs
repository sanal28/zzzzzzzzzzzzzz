﻿using ETLCenter.CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETLCenter.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [SessionAuthorize]
        public ActionResult EmployeeHome()
        {
            return View();
        }
    }
}