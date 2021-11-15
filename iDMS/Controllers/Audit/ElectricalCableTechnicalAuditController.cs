using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Controllers.Audit
{
    public class ElectricalCableTechnicalAuditController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Audit/ElectricalCableTechnicalAudit/ElectricalCableTechnical.cshtml");
        }
        [HttpGet]
        public ViewResult ElectricalCableTechnicalAudit()
        {
            return View("~/Views/Audit/ElectricalCableTechnicalAudit/ElectricalCableTechnical.cshtml");
        }
    }
}
