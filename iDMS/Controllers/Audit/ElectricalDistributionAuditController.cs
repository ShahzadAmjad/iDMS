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
            return View("ElectricalDistribution");
        }
        public ViewResult ElectricalDistributionAudit()
        {
            return View("ElectricalDistribution");
        }
    }
}
