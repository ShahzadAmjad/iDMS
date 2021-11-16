using iDMS.Models.Audit;
using iDMS.Models.Audit.HealthSafetyAudit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Controllers.Audit
{
    public class HealthSafetyAuditController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Audit/HealthSafetyAudit/HealthSafety.cshtml");
        }
        [HttpGet]
        public ViewResult HealthSafetyAudit()
        {
            HealthSafety healthSafety = new HealthSafety();
            healthSafety.auditQuestionsLst = new List<AuditQuestions>() { };
            AuditQuestions question1 = new AuditQuestions { qustionText = "Is the approved Health & Safety Plan and/or site-specific Method Statements on site?", ansawer = "Yes", comments = "NA" };


            AuditQuestions question2 = new AuditQuestions { qustionText = "Have all operatives accepted and signed onto the RAMS?", ansawer = "No", comments = "NA" };
            AuditQuestions question3 = new AuditQuestions { qustionText = "Is the site clean and generally tidy and contained within a secure working area?", ansawer = "Yes", comments = "NA" };
            AuditQuestions question4 = new AuditQuestions { qustionText = "Are all the drawings available on site?", ansawer = "Yes", comments = "NA" };
            AuditQuestions question5 = new AuditQuestions { qustionText = "Are all drawings available the latest versions?", ansawer = "Yes", comments = "NA" };
            AuditQuestions question6 = new AuditQuestions { qustionText = "Is a permit to work system (required for all work involving live electrical installations) being used?", ansawer = "Yes", comments = "NA" };
            healthSafety.auditQuestionsLst.Add(question1);
            healthSafety.auditQuestionsLst.Add(question2);
            healthSafety.auditQuestionsLst.Add(question3);
            healthSafety.auditQuestionsLst.Add(question4);
            healthSafety.auditQuestionsLst.Add(question5);
            healthSafety.auditQuestionsLst.Add(question6);
            //healthSafety.auditQuestionsLst.Add(question);
            //healthSafety.auditQuestionsLst.Add(question1);


            return View("~/Views/Audit/HealthSafetyAudit/HealthSafety.cshtml", healthSafety);
        }

        [HttpPost]
        public IActionResult HealthSafetyAudit(HealthSafety healthSafety)
        {

            return View();
        }
    }
}
