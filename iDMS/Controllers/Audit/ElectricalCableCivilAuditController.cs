﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Controllers.Audit
{
    public class ElectricalCableCivilAuditController : Controller
    {
        public IActionResult Index()
        {
            return View("ElectricalCableCivil");
        }
        [HttpGet]
        public ViewResult ElectricalCableCivilAudit()
        {
            return View("ElectricalCableCivil");
        }



    }
}
