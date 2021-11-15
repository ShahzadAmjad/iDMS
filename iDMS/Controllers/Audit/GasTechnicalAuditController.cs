﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Controllers.Audit
{
    public class GasTechnicalAuditController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Audit/GasTechnicalAudit/GasTechnical.cshtml");
        }
        public ViewResult GasTechnicalAudit()
        {
            return View("~/Views/Audit/GasTechnicalAudit/GasTechnical.cshtml");
        }
    }
}
