using iDMS.Models.Audit;
using iDMS.Models.Audit.ElectricalCableCivilAudit;
using Microsoft.AspNetCore.Mvc;
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
            return View("~/Views/Audit/ElectricalCableCivilAudit/ElectricalCableCivil.cshtml");
        }
        [HttpGet]
        public ViewResult ElectricalCableCivilAudit()
        {
            ElectricalCableCivil electricalCableCivil = new ElectricalCableCivil();
            electricalCableCivil.auditQuestionsLst = new List<AuditQuestions>() { };

            AuditQuestions question1 = new AuditQuestions { qustionText = "Is the approved Health & Safety Plan and/or site-specific Method Statements on site?", ansawer = "Yes" };
            AuditQuestions question2 = new AuditQuestions { qustionText = "Have all operatives accepted and signed onto the RAMS?", ansawer = "Yes" };
            AuditQuestions question3 = new AuditQuestions { qustionText = "Is the site clean and generally tidy and contained within a secure working area?", ansawer = "Yes" };
            AuditQuestions question4 = new AuditQuestions { qustionText = "Are all the drawings available on site?", ansawer = "Yes" };
            AuditQuestions question5 = new AuditQuestions { qustionText = "Are all drawings available the latest versions?", ansawer = "Yes" };
            AuditQuestions question6 = new AuditQuestions { qustionText = "Is a permit to work system (required for all work involving live electrical installations) being used?", ansawer = "Yes" };
            AuditQuestions question7 = new AuditQuestions { qustionText = "Is all equipment being tested before installing/modifying to ensure it has been isolated and is not live?", ansawer = "Yes" };
            AuditQuestions question8 = new AuditQuestions { qustionText = "Are all operatives using/wearing appropriate PPE? Ensure all mandatory PPE, including rubber mats and insulated tools, are used when working with live installation", ansawer = "Yes" };
            AuditQuestions question9 = new AuditQuestions { qustionText = "Does the equipment have a proper earthing connection to the supply?", ansawer = "Yes" };
            AuditQuestions question10 = new AuditQuestions { qustionText = "Do works reflect the safe system of work specified within the site-specific Method Statement?", ansawer = "Yes" };
            AuditQuestions question11 = new AuditQuestions { qustionText = "Has Contractor’s H&S officer carried out Weekly/Monthly Health & Safety checks (Toolbox Talks)?", ansawer = "Yes" };
            AuditQuestions question12 = new AuditQuestions { qustionText = "Have operatives been given a Toolbox Talk within the last month?", ansawer = "Yes" };
            AuditQuestions question13 = new AuditQuestions { qustionText = "Are all portable and hand-held tools in good working condition and adequately insulated?", ansawer = "Yes" };
            AuditQuestions question14 = new AuditQuestions { qustionText = "Is all mains voltage equipment free of any mechanical damage? ", ansawer = "Yes" };
            AuditQuestions question15 = new AuditQuestions { qustionText = "Are Daily Activity Briefings (DABs) taking place and is the information suitable and sufficient? ", ansawer = "Yes" };
            AuditQuestions question16 = new AuditQuestions { qustionText = "Do all operatives have relevant accreditations, and are they in date?", ansawer = "Yes" };
            AuditQuestions question17 = new AuditQuestions { qustionText = "Is/are competent person(s) undertaking the electrical installation works?", ansawer = "Yes" };
            AuditQuestions question18 = new AuditQuestions { qustionText = "Are there Emergency procedures in place for an electric shock casualty and are the required personnel aware of what to do in the event of such a casualty occurring?", ansawer = "Yes" };
            AuditQuestions question19 = new AuditQuestions { qustionText = "Are there sufficient toilet & welfare facilities available for use on site?", ansawer = "Yes" };
            AuditQuestions question20 = new AuditQuestions { qustionText = "Check for correct rating of fuses and switchgear at the point of supply If variation job, is all the documentation complete ?", ansawer = "Yes" };
            AuditQuestions question21 = new AuditQuestions { qustionText = "Is the client/site management satisfied with quality of work and compliance with site safety?", ansawer = "Yes" };
            AuditQuestions question22 = new AuditQuestions { qustionText = "Is team paperwork to required standard?", ansawer = "Yes" };
            AuditQuestions question23 = new AuditQuestions { qustionText = "Are/Were all power supplies isolated, with stringent lockout procedures in place and with all switchgear and distribution panels securely locked and signed, before works commence(d)?", ansawer = "Yes" };
            AuditQuestions question24 = new AuditQuestions { qustionText = "Are portable light fittings being used to prevent injuries and to be prepared for any hazardous situation?", ansawer = "Yes" };
            AuditQuestions question25 = new AuditQuestions { qustionText = "Are dedicated wire and cable strippers being used for wirings and cabling?", ansawer = "Yes" };
            AuditQuestions question26 = new AuditQuestions { qustionText = "Ensure of electrical installation work is a minimum two-man operation by one as competent personnel", ansawer = "Yes" };
            AuditQuestions question27 = new AuditQuestions { qustionText = "Are cables or wires being securely fixed so they do not create a trip hazard?", ansawer = "Yes" };
            AuditQuestions question28 = new AuditQuestions { qustionText = "Are all the materials being used in accordance with the relevant DNO’s/IDNO’s technical specification and requirements for the project, when checked against the Design Materials list?", ansawer = "Yes" };
            AuditQuestions question29 = new AuditQuestions { qustionText = "Is there a First Aid Kit, Eye Wash and Fire Extinguisher onsite and within expiry date?", ansawer = "Yes" };

            electricalCableCivil.auditQuestionsLst.Add(question1);
            electricalCableCivil.auditQuestionsLst.Add(question2);
            electricalCableCivil.auditQuestionsLst.Add(question3);
            electricalCableCivil.auditQuestionsLst.Add(question4);
            electricalCableCivil.auditQuestionsLst.Add(question5);
            electricalCableCivil.auditQuestionsLst.Add(question6);
            electricalCableCivil.auditQuestionsLst.Add(question7);
            electricalCableCivil.auditQuestionsLst.Add(question8);
            electricalCableCivil.auditQuestionsLst.Add(question9);
            electricalCableCivil.auditQuestionsLst.Add(question10);
            electricalCableCivil.auditQuestionsLst.Add(question11);
            electricalCableCivil.auditQuestionsLst.Add(question12);
            electricalCableCivil.auditQuestionsLst.Add(question13);
            electricalCableCivil.auditQuestionsLst.Add(question14);
            electricalCableCivil.auditQuestionsLst.Add(question15);
            electricalCableCivil.auditQuestionsLst.Add(question16);
            electricalCableCivil.auditQuestionsLst.Add(question17);
            electricalCableCivil.auditQuestionsLst.Add(question18);
            electricalCableCivil.auditQuestionsLst.Add(question19);
            electricalCableCivil.auditQuestionsLst.Add(question20);
            electricalCableCivil.auditQuestionsLst.Add(question21);
            electricalCableCivil.auditQuestionsLst.Add(question22);
            electricalCableCivil.auditQuestionsLst.Add(question23);
            electricalCableCivil.auditQuestionsLst.Add(question24);
            electricalCableCivil.auditQuestionsLst.Add(question25);
            electricalCableCivil.auditQuestionsLst.Add(question26);
            electricalCableCivil.auditQuestionsLst.Add(question27);
            electricalCableCivil.auditQuestionsLst.Add(question28);
            electricalCableCivil.auditQuestionsLst.Add(question29);



            
            return View("~/Views/Audit/ElectricalCableCivilAudit/ElectricalCableCivil.cshtml", electricalCableCivil);
        }



    }
}
