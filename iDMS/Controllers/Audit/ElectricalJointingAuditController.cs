﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Controllers.Audit
{
    public class ElectricalJointingAuditController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Audit/ElectricalJointingAudit/ElectricalJointing.cshtml");
        }
        public ViewResult ElectricalJointingAudit()
        {
            return View("~/Views/Audit/ElectricalJointingAudit/ElectricalJointing.cshtml");
        }
    }
}
