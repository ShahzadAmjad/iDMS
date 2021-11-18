using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Controllers.Audit
{
    public class ElectricalDistributionAuditController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Audit/ElectricalDistributionAudit/ElectricalDistribution.cshtml");
        }
        [HttpGet]
        public ViewResult ElectricalDistributionAudit()
        {
            return View("~/Views/Audit/ElectricalDistributionAudit/ElectricalDistribution.cshtml");
        }
    }
}
