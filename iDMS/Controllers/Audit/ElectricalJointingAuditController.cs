using iDMS.Models.Audit;
using iDMS.Models.Audit.ElectricalJointingAudit;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public ViewResult ElectricalJointingAudit()
        {
            ElectricalJointing electricalJointing = new ElectricalJointing();
            electricalJointing.auditQuestionsLst = new List<AuditQuestions>() { };
            //Documents
            AuditQuestions question1 = new AuditQuestions { qustionText = "Qualifications (specific to role)" };
            AuditQuestions question2 = new AuditQuestions { qustionText = "NRSWA" };
            AuditQuestions question3 = new AuditQuestions { qustionText = "EUSR(E) / CSCS Card" };
            AuditQuestions question4 = new AuditQuestions { qustionText = "Competency Certificate(s)" };
            AuditQuestions question5 = new AuditQuestions { qustionText = "Work Instruction" };
            AuditQuestions question6 = new AuditQuestions { qustionText = "Distribution Safety Rules" };
            AuditQuestions question7 = new AuditQuestions { qustionText = "Commissioned Drawing" };
            AuditQuestions question8 = new AuditQuestions { qustionText = "Risk Assessments completed covering all Works being carried out" };
            AuditQuestions question9 = new AuditQuestions { qustionText = "Site-specific Risk Assessments" };
            AuditQuestions question10 = new AuditQuestions { qustionText = "Work Activity Method Statement" };
            AuditQuestions question11 = new AuditQuestions { qustionText = "Cable Identified (type: Tape / SWA / PVC)" };
            AuditQuestions question12 = new AuditQuestions { qustionText = "Voltage of Work being worked on" };
            AuditQuestions question13 = new AuditQuestions { qustionText = "Existing As-Laid Drawings available" };
            AuditQuestions question14 = new AuditQuestions { qustionText = "Safety Documents issued" };
            AuditQuestions question15 = new AuditQuestions { qustionText = "Permit to Work" };
            AuditQuestions question16 = new AuditQuestions { qustionText = "Sanction for Test" };
            AuditQuestions question17 = new AuditQuestions { qustionText = "Limitation of Access" };
            AuditQuestions question18 = new AuditQuestions { qustionText = "Passport up-to-date" };
            AuditQuestions question19 = new AuditQuestions { qustionText = "ID Card" };
            electricalJointing.auditQuestionsLst.Add(question1);
            electricalJointing.auditQuestionsLst.Add(question2);
            electricalJointing.auditQuestionsLst.Add(question3);
            electricalJointing.auditQuestionsLst.Add(question4);
            electricalJointing.auditQuestionsLst.Add(question5);
            electricalJointing.auditQuestionsLst.Add(question6);
            electricalJointing.auditQuestionsLst.Add(question7);
            electricalJointing.auditQuestionsLst.Add(question8);
            electricalJointing.auditQuestionsLst.Add(question9);
            electricalJointing.auditQuestionsLst.Add(question10);
            electricalJointing.auditQuestionsLst.Add(question11);
            electricalJointing.auditQuestionsLst.Add(question12);
            electricalJointing.auditQuestionsLst.Add(question13);
            electricalJointing.auditQuestionsLst.Add(question14);
            electricalJointing.auditQuestionsLst.Add(question15);
            electricalJointing.auditQuestionsLst.Add(question16);
            electricalJointing.auditQuestionsLst.Add(question17);
            electricalJointing.auditQuestionsLst.Add(question18);
            electricalJointing.auditQuestionsLst.Add(question19);

            //electricalJointing
            AuditQuestions question20 = new AuditQuestions { qustionText = "Type of Cable(s) TXLPE, SACXLPE, WAVEFORM, CNE SERVICE" };
            AuditQuestions question21 = new AuditQuestions { qustionText = "Main Size" };
            electricalJointing.auditQuestionsLst.Add(question20);
            electricalJointing.auditQuestionsLst.Add(question21);

            //Type of Jointing being carried out (heading - not question)(conditional)
            AuditQuestions question22 = new AuditQuestions { qustionText = "Service" };
            AuditQuestions question23 = new AuditQuestions { qustionText = "Mains Breech Joint" };
            AuditQuestions question24 = new AuditQuestions { qustionText = "Pot End" };
            AuditQuestions question25 = new AuditQuestions { qustionText = "2 Way Link Box" };
            AuditQuestions question26 = new AuditQuestions { qustionText = "4 Way Link Box" };
            AuditQuestions question27 = new AuditQuestions { qustionText = "MSDB fitted (number of ways)" };
            AuditQuestions question28 = new AuditQuestions { qustionText = "100 amp Cut Out" };
            AuditQuestions question29 = new AuditQuestions { qustionText = "200 amp Cut Out" };
            AuditQuestions question30 = new AuditQuestions { qustionText = "400 amp Cut Out (up to 185mm WF cable)" };
            AuditQuestions question31 = new AuditQuestions { qustionText = "600 amp Cut Out (300mm WF cable)" };
            AuditQuestions question32 = new AuditQuestions { qustionText = "CT Ratio Size" };
            AuditQuestions question33 = new AuditQuestions { qustionText = "Other" };
            
            
            electricalJointing.auditQuestionsLst.Add(question22);
            electricalJointing.auditQuestionsLst.Add(question23);
            electricalJointing.auditQuestionsLst.Add(question24);
            electricalJointing.auditQuestionsLst.Add(question25);
            electricalJointing.auditQuestionsLst.Add(question26);
            electricalJointing.auditQuestionsLst.Add(question27);
            electricalJointing.auditQuestionsLst.Add(question28);
            electricalJointing.auditQuestionsLst.Add(question29);
            electricalJointing.auditQuestionsLst.Add(question30);
            electricalJointing.auditQuestionsLst.Add(question31);
            electricalJointing.auditQuestionsLst.Add(question32);
            electricalJointing.auditQuestionsLst.Add(question33);

            //Testing  
            AuditQuestions question34 = new AuditQuestions { qustionText = "Insulation Resistance" };
            AuditQuestions question35 = new AuditQuestions { qustionText = "Continuity" };
            AuditQuestions question36 = new AuditQuestions { qustionText = "Earth Loop Impedance" };
            AuditQuestions question37 = new AuditQuestions { qustionText = "Earth Electrodes" };
            AuditQuestions question38 = new AuditQuestions { qustionText = "HV Pressure Test" };
            electricalJointing.auditQuestionsLst.Add(question34);
            electricalJointing.auditQuestionsLst.Add(question35);
            electricalJointing.auditQuestionsLst.Add(question36);
            electricalJointing.auditQuestionsLst.Add(question37);
            electricalJointing.auditQuestionsLst.Add(question38);

            //Workplace  
            AuditQuestions question39 = new AuditQuestions { qustionText = "Joint Hole Correct Size" };
            AuditQuestions question40 = new AuditQuestions { qustionText = "Joint Hole Safe to Work in" };
            AuditQuestions question41 = new AuditQuestions { qustionText = "Excavations Shuttered/ Battered" };
            AuditQuestions question42 = new AuditQuestions { qustionText = "Correct Materials Available/ Being used" };
            AuditQuestions question43 = new AuditQuestions { qustionText = "Site Protection" };

            electricalJointing.auditQuestionsLst.Add(question39);
            electricalJointing.auditQuestionsLst.Add(question40);
            electricalJointing.auditQuestionsLst.Add(question41);
            electricalJointing.auditQuestionsLst.Add(question42);
            electricalJointing.auditQuestionsLst.Add(question43);

            //Equipment Positioning  
            AuditQuestions question44 = new AuditQuestions { qustionText = "PME Rods installed Correctly" };
            AuditQuestions question45 = new AuditQuestions { qustionText = "Meter Position Correct / Secure / Waterproof" };
            AuditQuestions question46 = new AuditQuestions { qustionText = "Cut Out Installed Correctly / Secure / Waterproof" };
            AuditQuestions question47 = new AuditQuestions { qustionText = "Cables / Furniture Installed Correctly" };
            AuditQuestions question48 = new AuditQuestions { qustionText = "Trench Bedding" };
            AuditQuestions question49 = new AuditQuestions { qustionText = "Depth" };
            AuditQuestions question50 = new AuditQuestions { qustionText = "Location / Position" };
            electricalJointing.auditQuestionsLst.Add(question44);
            electricalJointing.auditQuestionsLst.Add(question45);
            electricalJointing.auditQuestionsLst.Add(question46);
            electricalJointing.auditQuestionsLst.Add(question47);
            electricalJointing.auditQuestionsLst.Add(question48);
            electricalJointing.auditQuestionsLst.Add(question49);
            electricalJointing.auditQuestionsLst.Add(question50);

            //Work Practices  
            AuditQuestions question51 = new AuditQuestions { qustionText = "Jointing work carried out to COP instructions- mains and services" };
            AuditQuestions question52 = new AuditQuestions { qustionText = "Correct “Live working” procedures being used" };
            AuditQuestions question53 = new AuditQuestions { qustionText = "Earth maintained and shrouding used on exposed live conductors" };
            AuditQuestions question54 = new AuditQuestions { qustionText = "Cable stripped and prepared correctly" };
            AuditQuestions question55 = new AuditQuestions { qustionText = "Cable cores insulated properly" };
            AuditQuestions question56 = new AuditQuestions { qustionText = "Correct cable connectors used" };
            AuditQuestions question57 = new AuditQuestions { qustionText = "“Cold pour” jointing resin mixed correctly" };
            AuditQuestions question58 = new AuditQuestions { qustionText = "Joint shell/ box sealed correctly" };
            AuditQuestions question59 = new AuditQuestions { qustionText = "Polarity/ rotation checks completed and recorded" };

            electricalJointing.auditQuestionsLst.Add(question51);
            electricalJointing.auditQuestionsLst.Add(question52);
            electricalJointing.auditQuestionsLst.Add(question53);
            electricalJointing.auditQuestionsLst.Add(question54);
            electricalJointing.auditQuestionsLst.Add(question55);
            electricalJointing.auditQuestionsLst.Add(question56);
            electricalJointing.auditQuestionsLst.Add(question57);
            electricalJointing.auditQuestionsLst.Add(question58);
            electricalJointing.auditQuestionsLst.Add(question59);

            //Equipment  




            return View("~/Views/Audit/ElectricalJointingAudit/ElectricalJointing.cshtml", electricalJointing);
        }
        [HttpPost]
        public IActionResult ElectricalJointingAudit(ElectricalJointing electricalJointing)
        {
            //_electricalJointingRepository.Add(electricalJointing);
            return View("~/Views/Audit/ElectricalJointingAudit/ElectricalJointing.cshtml");
        }
    }
}
