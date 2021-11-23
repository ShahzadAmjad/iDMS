using iDMS.Models.Audit;
using iDMS.Models.Audit.ElectricalCableTechnical;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Controllers.Audit
{
    public class ElectricalCableTechnicalAuditController : Controller
    {
        //private IElectricalCableTechnicalRepository _electricalCableTechnicalRepository;
        public ElectricalCableTechnicalAuditController()
        {

        }
        public IActionResult Index()
        {
            return View("~/Views/Audit/ElectricalCableTechnicalAudit/ElectricalCableTechnical.cshtml");
        }
        [HttpGet]
        public ViewResult ElectricalCableTechnicalAudit()
        {
            ElectricalCableTechnical electricalCableTechnical = new ElectricalCableTechnical();
            electricalCableTechnical.auditQuestionsLst = new List<AuditQuestions>() { };


            //Documents
            AuditQuestions question1 = new AuditQuestions { qustionText = "Drawing No" };
            AuditQuestions question2 = new AuditQuestions { qustionText = "Jointing instruction / Permit to work" };
            AuditQuestions question3 = new AuditQuestions { qustionText = "Other Utilities drawings" };
            AuditQuestions question4 = new AuditQuestions { qustionText = "Site Specific Risk Assessment" };
            AuditQuestions question5 = new AuditQuestions { qustionText = "Commissioned Mains Drawing" };
            AuditQuestions question6 = new AuditQuestions { qustionText = "Work Instruction" };
            electricalCableTechnical.auditQuestionsLst.Add(question1);
            electricalCableTechnical.auditQuestionsLst.Add(question2);
            electricalCableTechnical.auditQuestionsLst.Add(question3);
            electricalCableTechnical.auditQuestionsLst.Add(question4);
            electricalCableTechnical.auditQuestionsLst.Add(question5);
            electricalCableTechnical.auditQuestionsLst.Add(question6);

            //Excavation 
            AuditQuestions question7 = new AuditQuestions { qustionText = "Excavation Fencing" };
            AuditQuestions question8 = new AuditQuestions { qustionText = "Trench Bed" };
            AuditQuestions question9 = new AuditQuestions { qustionText = "Trench Support" };
            AuditQuestions question10 = new AuditQuestions { qustionText = "Ducting" };
            electricalCableTechnical.auditQuestionsLst.Add(question7);
            electricalCableTechnical.auditQuestionsLst.Add(question8);
            electricalCableTechnical.auditQuestionsLst.Add(question9);
            electricalCableTechnical.auditQuestionsLst.Add(question10);

            //o	3 Mains Cable 
            AuditQuestions question11 = new AuditQuestions { qustionText = "Size" };
            AuditQuestions question12 = new AuditQuestions { qustionText = "Depth" };
            AuditQuestions question13 = new AuditQuestions { qustionText = "Location" };
            AuditQuestions question14 = new AuditQuestions { qustionText = "Type HV / LV" };
            AuditQuestions question15 = new AuditQuestions { qustionText = "Test" };
            AuditQuestions question16 = new AuditQuestions { qustionText = "Marker Tape" };
            AuditQuestions question17 = new AuditQuestions { qustionText = "Method Statement" }; //(does not include ‘specify’ field)
            electricalCableTechnical.auditQuestionsLst.Add(question11);
            electricalCableTechnical.auditQuestionsLst.Add(question12);
            electricalCableTechnical.auditQuestionsLst.Add(question13);
            electricalCableTechnical.auditQuestionsLst.Add(question14);
            electricalCableTechnical.auditQuestionsLst.Add(question15);
            electricalCableTechnical.auditQuestionsLst.Add(question16);
            electricalCableTechnical.auditQuestionsLst.Add(question17);

            //Jointing 
            AuditQuestions question18 = new AuditQuestions { qustionText = "H. V / L.V" };
            AuditQuestions question19 = new AuditQuestions { qustionText = "Straight" };
            AuditQuestions question20 = new AuditQuestions { qustionText = "Breech" };
            AuditQuestions question21 = new AuditQuestions { qustionText = "Pot End" };
            AuditQuestions question22 = new AuditQuestions { qustionText = "Link Box" };
            AuditQuestions question23 = new AuditQuestions { qustionText = "Multi Head" };
            AuditQuestions question24 = new AuditQuestions { qustionText = "Pole Termination" };
            AuditQuestions question25 = new AuditQuestions { qustionText = "Switchgear Termination" };
            AuditQuestions question26 = new AuditQuestions { qustionText = "Method Statement" }; //(does not include ‘specify’ field)
            electricalCableTechnical.auditQuestionsLst.Add(question18);
            electricalCableTechnical.auditQuestionsLst.Add(question19);
            electricalCableTechnical.auditQuestionsLst.Add(question20);
            electricalCableTechnical.auditQuestionsLst.Add(question21);
            electricalCableTechnical.auditQuestionsLst.Add(question22);
            electricalCableTechnical.auditQuestionsLst.Add(question23);
            electricalCableTechnical.auditQuestionsLst.Add(question24);
            electricalCableTechnical.auditQuestionsLst.Add(question25);
            electricalCableTechnical.auditQuestionsLst.Add(question26);

            //Service Cable 
            AuditQuestions question27 = new AuditQuestions { qustionText = "Size" };
            AuditQuestions question28 = new AuditQuestions { qustionText = "Depth" };
            AuditQuestions question29 = new AuditQuestions { qustionText = "Developer Ducts" };
            AuditQuestions question30 = new AuditQuestions { qustionText = "Cable Guard" };
            AuditQuestions question31 = new AuditQuestions { qustionText = "Test" };
            AuditQuestions question32 = new AuditQuestions { qustionText = "Meter box Secure" };
            AuditQuestions question33 = new AuditQuestions { qustionText = "PME Label Fitted" };
            AuditQuestions question34 = new AuditQuestions { qustionText = "Phase Colour label" };
            AuditQuestions question35 = new AuditQuestions { qustionText = "Rising services" };
            AuditQuestions question36 = new AuditQuestions { qustionText = "Cut Out Position" };
            AuditQuestions question37 = new AuditQuestions { qustionText = "Method Statement" }; //(does not include ‘specify’ field)
            electricalCableTechnical.auditQuestionsLst.Add(question27);
            electricalCableTechnical.auditQuestionsLst.Add(question28);
            electricalCableTechnical.auditQuestionsLst.Add(question29);
            electricalCableTechnical.auditQuestionsLst.Add(question30);
            electricalCableTechnical.auditQuestionsLst.Add(question31);
            electricalCableTechnical.auditQuestionsLst.Add(question32);
            electricalCableTechnical.auditQuestionsLst.Add(question33);
            electricalCableTechnical.auditQuestionsLst.Add(question34);
            electricalCableTechnical.auditQuestionsLst.Add(question35);
            electricalCableTechnical.auditQuestionsLst.Add(question36);
            electricalCableTechnical.auditQuestionsLst.Add(question37);

            //Tools & Equipment 
            AuditQuestions question38 = new AuditQuestions { qustionText = "Test Equipment" };
            AuditQuestions question39 = new AuditQuestions { qustionText = "Earth loop imp. Test" };
            AuditQuestions question40 = new AuditQuestions { qustionText = "IR Test" };
            AuditQuestions question41 = new AuditQuestions { qustionText = "LV testing lamp" };
            AuditQuestions question42 = new AuditQuestions { qustionText = "Pressure test" };
            AuditQuestions question43 = new AuditQuestions { qustionText = "Phase rotation meter" };
            AuditQuestions question44 = new AuditQuestions { qustionText = "Cable Locator" };
            AuditQuestions question45 = new AuditQuestions { qustionText = "Fire Extinguisher 1" };
            AuditQuestions question46 = new AuditQuestions { qustionText = "Fire Extinguisher 2" };
            AuditQuestions question47 = new AuditQuestions { qustionText = "First aid kit" };
            AuditQuestions question48 = new AuditQuestions { qustionText = "Eye Wash" };
            AuditQuestions question49 = new AuditQuestions { qustionText = "Earth Instrument test" };
            AuditQuestions question50 = new AuditQuestions { qustionText = "Van" };
            electricalCableTechnical.auditQuestionsLst.Add(question38);
            electricalCableTechnical.auditQuestionsLst.Add(question39);
            electricalCableTechnical.auditQuestionsLst.Add(question40);
            electricalCableTechnical.auditQuestionsLst.Add(question41);
            electricalCableTechnical.auditQuestionsLst.Add(question42);
            electricalCableTechnical.auditQuestionsLst.Add(question43);
            electricalCableTechnical.auditQuestionsLst.Add(question44);
            electricalCableTechnical.auditQuestionsLst.Add(question45);
            electricalCableTechnical.auditQuestionsLst.Add(question46);
            electricalCableTechnical.auditQuestionsLst.Add(question47);
            electricalCableTechnical.auditQuestionsLst.Add(question48);
            electricalCableTechnical.auditQuestionsLst.Add(question49);
            electricalCableTechnical.auditQuestionsLst.Add(question50);

            //o	Accreditation 
            AuditQuestions question51 = new AuditQuestions { qustionText = "Jointing Passport/ Certificate" };
            AuditQuestions question52 = new AuditQuestions { qustionText = "Winching Certificate" };
            electricalCableTechnical.auditQuestionsLst.Add(question51);
            electricalCableTechnical.auditQuestionsLst.Add(question52);

            //o	Testing 
            AuditQuestions question53 = new AuditQuestions { qustionText = "Insulation Resistance" };
            AuditQuestions question54 = new AuditQuestions { qustionText = "Continuity" };
            AuditQuestions question55 = new AuditQuestions { qustionText = "Earth Loop Impedance" };
            AuditQuestions question56 = new AuditQuestions { qustionText = "Earth Electrodes" };
            AuditQuestions question57 = new AuditQuestions { qustionText = "HV Pressure Test" };
            electricalCableTechnical.auditQuestionsLst.Add(question53);
            electricalCableTechnical.auditQuestionsLst.Add(question54);
            electricalCableTechnical.auditQuestionsLst.Add(question55);
            electricalCableTechnical.auditQuestionsLst.Add(question56);
            electricalCableTechnical.auditQuestionsLst.Add(question57);

            //PPE
            AuditQuestions question58 = new AuditQuestions { qustionText = "Hard Hat" };
            AuditQuestions question59 = new AuditQuestions { qustionText = "Eye Protection" };
            AuditQuestions question60 = new AuditQuestions { qustionText = "Ear Defenders" };
            AuditQuestions question61 = new AuditQuestions { qustionText = "Flame Retardant Coverall" };
            AuditQuestions question62 = new AuditQuestions { qustionText = "Footwear" };
            AuditQuestions question63 = new AuditQuestions { qustionText = "High viz" };
            AuditQuestions question64 = new AuditQuestions { qustionText = "Gloves" };
            electricalCableTechnical.auditQuestionsLst.Add(question58);
            electricalCableTechnical.auditQuestionsLst.Add(question59);
            electricalCableTechnical.auditQuestionsLst.Add(question60);
            electricalCableTechnical.auditQuestionsLst.Add(question61);
            electricalCableTechnical.auditQuestionsLst.Add(question62);
            electricalCableTechnical.auditQuestionsLst.Add(question63);
            electricalCableTechnical.auditQuestionsLst.Add(question64);

            return View("~/Views/Audit/ElectricalCableTechnicalAudit/ElectricalCableTechnical.cshtml", electricalCableTechnical);
        }

        [HttpPost]
        public IActionResult ElectricalCableTechnicalAudit(ElectricalCableTechnical electricalCableTechnical)
        {
           // _electricalCableTechnicalRepository.Add(electricalCableTechnical);
            return View("~/Views/Audit/ElectricalCableTechnicalAudit/ElectricalCableTechnical.cshtml");
        }
    }
}
