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
            AuditQuestions question1 = new AuditQuestions { qustionText = "Is the approved Health & Safety Plan and/or site-specific Method Statements on site?", comments = "" };
            AuditQuestions question2 = new AuditQuestions { qustionText = "Have all operatives accepted and signed onto the RAMS?", comments = "" };
            AuditQuestions question3 = new AuditQuestions { qustionText = "Is the site clean and generally tidy and contained within a secure working area?", comments = "" };
            AuditQuestions question4 = new AuditQuestions { qustionText = "Are all the drawings available on site?", comments = "" };
            AuditQuestions question5 = new AuditQuestions { qustionText = "Are all drawings available the latest versions?", comments = "" };
            AuditQuestions question6 = new AuditQuestions { qustionText = "Is a permit to work system (required for all work involving live electrical installations) being used?", comments = "" };
            AuditQuestions question7 = new AuditQuestions { qustionText = "Is all equipment being tested before installing/modifying to ensure it has been isolated and is not live?", comments = "" };
            AuditQuestions question8 = new AuditQuestions { qustionText = "Are all operatives using/wearing appropriate PPE? Ensure all mandatory PPE, including rubber mats and insulated tools, are used when working with live installation", comments = "" };
            AuditQuestions question9 = new AuditQuestions { qustionText = "Does the equipment have a proper earthing connection to the supply?", comments = "" };
            AuditQuestions question10 = new AuditQuestions { qustionText = "Do works reflect the safe system of work specified within the site-specific Method Statement?", comments = "" };
            AuditQuestions question11 = new AuditQuestions { qustionText = "Has Contractor’s H&S officer carried out Weekly/Monthly Health & Safety checks (Toolbox Talks)?", comments = "" };
            AuditQuestions question12 = new AuditQuestions { qustionText = "Have operatives been given a Toolbox Talk within the last month?", comments = "" };
            AuditQuestions question13 = new AuditQuestions { qustionText = "Are all portable and hand-held tools in good working condition and adequately insulated?", comments = "" };
            AuditQuestions question14 = new AuditQuestions { qustionText = "Is all mains voltage equipment free of any mechanical damage? ", comments = "" };
            AuditQuestions question15 = new AuditQuestions { qustionText = "Are Daily Activity Briefings (DABs) taking place and is the information suitable and sufficient? ", comments = "" };
            AuditQuestions question16 = new AuditQuestions { qustionText = "Do all operatives have relevant accreditations, and are they in date?", comments = "" };
            AuditQuestions question17 = new AuditQuestions { qustionText = "Is/are competent person(s) undertaking the electrical installation works?", comments = "" };
            AuditQuestions question18 = new AuditQuestions { qustionText = "Are there Emergency procedures in place for an electric shock casualty and are the required personnel aware of what to do in the event of such a casualty occurring?", comments = "" };
            AuditQuestions question19 = new AuditQuestions { qustionText = "Are there sufficient toilet & welfare facilities available for use on site?", comments = "" };
            AuditQuestions question20 = new AuditQuestions { qustionText = "Check for correct rating of fuses and switchgear at the point of supply If variation job, is all the documentation complete ?", comments = "" };
            AuditQuestions question21 = new AuditQuestions { qustionText = "Is the client/site management satisfied with quality of work and compliance with site safety?", comments = "" };
            AuditQuestions question22 = new AuditQuestions { qustionText = "Is team paperwork to required standard?", comments = "" };
            AuditQuestions question23 = new AuditQuestions { qustionText = "Are/Were all power supplies isolated, with stringent lockout procedures in place and with all switchgear and distribution panels securely locked and signed, before works commence(d)?", comments = "" };
            AuditQuestions question24 = new AuditQuestions { qustionText = "Are portable light fittings being used to prevent injuries and to be prepared for any hazardous situation?", comments = "" };
            AuditQuestions question25 = new AuditQuestions { qustionText = "Are dedicated wire and cable strippers being used for wirings and cabling?", comments = "" };
            AuditQuestions question26 = new AuditQuestions { qustionText = "Ensure of electrical installation work is a minimum two-man operation by one as competent personnel", comments = "" };
            AuditQuestions question27 = new AuditQuestions { qustionText = "Are cables or wires being securely fixed so they do not create a trip hazard?", comments = "" };
            AuditQuestions question28 = new AuditQuestions { qustionText = "Are all the materials being used in accordance with the relevant DNO’s/IDNO’s technical specification and requirements for the project, when checked against the Design Materials list?", comments = "" };
            AuditQuestions question29 = new AuditQuestions { qustionText = "Is there a First Aid Kit, Eye Wash and Fire Extinguisher onsite and within expiry date?", comments = "" };

            healthSafety.auditQuestionsLst.Add(question1);
            healthSafety.auditQuestionsLst.Add(question2);
            healthSafety.auditQuestionsLst.Add(question3);
            healthSafety.auditQuestionsLst.Add(question4);
            healthSafety.auditQuestionsLst.Add(question5);
            healthSafety.auditQuestionsLst.Add(question6);
            healthSafety.auditQuestionsLst.Add(question7);
            healthSafety.auditQuestionsLst.Add(question8);
            healthSafety.auditQuestionsLst.Add(question9);
            healthSafety.auditQuestionsLst.Add(question10);

            healthSafety.auditQuestionsLst.Add(question11);
            healthSafety.auditQuestionsLst.Add(question12);
            healthSafety.auditQuestionsLst.Add(question13);
            healthSafety.auditQuestionsLst.Add(question14);
            healthSafety.auditQuestionsLst.Add(question15);
            healthSafety.auditQuestionsLst.Add(question16);
            healthSafety.auditQuestionsLst.Add(question17);
            healthSafety.auditQuestionsLst.Add(question18);
            healthSafety.auditQuestionsLst.Add(question19);
            healthSafety.auditQuestionsLst.Add(question20);
            healthSafety.auditQuestionsLst.Add(question21);
            healthSafety.auditQuestionsLst.Add(question22);
            healthSafety.auditQuestionsLst.Add(question23);
            healthSafety.auditQuestionsLst.Add(question24);
            healthSafety.auditQuestionsLst.Add(question25);
            healthSafety.auditQuestionsLst.Add(question26);
            healthSafety.auditQuestionsLst.Add(question27);
            healthSafety.auditQuestionsLst.Add(question28);
            healthSafety.auditQuestionsLst.Add(question29);


            return View("~/Views/Audit/HealthSafetyAudit/HealthSafety.cshtml", healthSafety);
        }

        [HttpPost]
        public IActionResult HealthSafetyAudit(HealthSafety healthSafety)
        {

            return View();
        }
    }
}
