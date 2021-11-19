using iDMS.Models.Audit;
using iDMS.Models.Audit.ElectricalDistributionAudit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Controllers.Audit
{
    public class ElectricalDistributionAuditController : Controller
    {
        public ElectricalDistributionAuditController()
        {
                
        }
        public IActionResult Index()
        {
            return View("~/Views/Audit/ElectricalDistributionAudit/ElectricalDistribution.cshtml");
        }
        [HttpGet]
        public ViewResult ElectricalDistributionAudit()
        {
            ElectricalDistribution electricalDistribution = new ElectricalDistribution();
            electricalDistribution.auditQuestionsLst = new List<AuditQuestions>() { };

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
            AuditQuestions question19 = new AuditQuestions { qustionText = "Fitting Codes of Practice Available" };
            electricalDistribution.auditQuestionsLst.Add(question1);
            electricalDistribution.auditQuestionsLst.Add(question2);
            electricalDistribution.auditQuestionsLst.Add(question3);
            electricalDistribution.auditQuestionsLst.Add(question4);
            electricalDistribution.auditQuestionsLst.Add(question5);
            electricalDistribution.auditQuestionsLst.Add(question6);
            electricalDistribution.auditQuestionsLst.Add(question7);
            electricalDistribution.auditQuestionsLst.Add(question8);
            electricalDistribution.auditQuestionsLst.Add(question9);
            electricalDistribution.auditQuestionsLst.Add(question10);
            electricalDistribution.auditQuestionsLst.Add(question11);
            electricalDistribution.auditQuestionsLst.Add(question12);
            electricalDistribution.auditQuestionsLst.Add(question13);
            electricalDistribution.auditQuestionsLst.Add(question14);
            electricalDistribution.auditQuestionsLst.Add(question15);
            electricalDistribution.auditQuestionsLst.Add(question16);
            electricalDistribution.auditQuestionsLst.Add(question17);
            electricalDistribution.auditQuestionsLst.Add(question18);
            electricalDistribution.auditQuestionsLst.Add(question19);


            //Substation Work 
            AuditQuestions question20 = new AuditQuestions { qustionText = "Correct materials available" };
            AuditQuestions question21 = new AuditQuestions { qustionText = "Correct tools available" };
            AuditQuestions question22 = new AuditQuestions { qustionText = "Substation earthling correct (Visual) (Hot or Cold site)" };
            AuditQuestions question23 = new AuditQuestions { qustionText = "Main Size" };
            AuditQuestions question24 = new AuditQuestions { qustionText = "Time limit fuses fitted" };
            AuditQuestions question25 = new AuditQuestions { qustionText = "Cables terminated correctly" };
            AuditQuestions question26 = new AuditQuestions { qustionText = "Locks fitted correctly" };
            AuditQuestions question27 = new AuditQuestions { qustionText = "HV circuit labels fitted" };
            AuditQuestions question28 = new AuditQuestions { qustionText = "LV circuit labels fitted" };
            AuditQuestions question29 = new AuditQuestions { qustionText = "Danger and substation name fitted" };
            AuditQuestions question30 = new AuditQuestions { qustionText = "SF6 label fitted and gauge in green (if present)" };
            AuditQuestions question31 = new AuditQuestions { qustionText = "Site secure" };
            AuditQuestions question32 = new AuditQuestions { qustionText = "Breather cap removed and tap changer locked off" };
            AuditQuestions question33 = new AuditQuestions { qustionText = "Open LV board barriered off/ shrouded (if present)" };
            AuditQuestions question34 = new AuditQuestions { qustionText = "Fitting carried out to instruction-HV and LV" };
            AuditQuestions question35 = new AuditQuestions { qustionText = "Lighting connected and working" };
            AuditQuestions question36 = new AuditQuestions { qustionText = "Polarity / rotation checked" };
            electricalDistribution.auditQuestionsLst.Add(question20);
            electricalDistribution.auditQuestionsLst.Add(question21);
            electricalDistribution.auditQuestionsLst.Add(question22);
            electricalDistribution.auditQuestionsLst.Add(question23);
            electricalDistribution.auditQuestionsLst.Add(question24);
            electricalDistribution.auditQuestionsLst.Add(question25);
            electricalDistribution.auditQuestionsLst.Add(question26);
            electricalDistribution.auditQuestionsLst.Add(question27);
            electricalDistribution.auditQuestionsLst.Add(question28);
            electricalDistribution.auditQuestionsLst.Add(question29);
            electricalDistribution.auditQuestionsLst.Add(question30);
            electricalDistribution.auditQuestionsLst.Add(question31);
            electricalDistribution.auditQuestionsLst.Add(question32);
            electricalDistribution.auditQuestionsLst.Add(question33);
            electricalDistribution.auditQuestionsLst.Add(question34);
            electricalDistribution.auditQuestionsLst.Add(question35);
            electricalDistribution.auditQuestionsLst.Add(question36);

            //Substation Maintenance
            AuditQuestions question37 = new AuditQuestions { qustionText = "Correct modification information available" };
            AuditQuestions question38 = new AuditQuestions { qustionText = "Correct modification being carried out" };
            AuditQuestions question39 = new AuditQuestions { qustionText = "Repeatable modifications being carried out" };
            AuditQuestions question40 = new AuditQuestions { qustionText = "Exposed internal components protected from the elements" };
            AuditQuestions question41 = new AuditQuestions { qustionText = "PRM label fitted" };
            AuditQuestions question42 = new AuditQuestions { qustionText = "Switchgear clean" };
            AuditQuestions question43 = new AuditQuestions { qustionText = "Switchgear locks oiled" };
            AuditQuestions question44 = new AuditQuestions { qustionText = "Switchgear patch painted" };
            AuditQuestions question45 = new AuditQuestions { qustionText = "Switchgear circuit labels readable" };
            AuditQuestions question46 = new AuditQuestions { qustionText = "Switchgear oil leaks" };
            AuditQuestions question47 = new AuditQuestions { qustionText = "Transformer clean" };
            AuditQuestions question48 = new AuditQuestions { qustionText = "Transformer locks oiled" };
            AuditQuestions question49 = new AuditQuestions { qustionText = "Transformer patch painted" };
            AuditQuestions question50 = new AuditQuestions { qustionText = "LV pillar / cabinet cleaned inside" };
            AuditQuestions question51 = new AuditQuestions { qustionText = "LV pillar / cabinet cleaned outside" };
            AuditQuestions question52 = new AuditQuestions { qustionText = "LV pillar / cabinet circuit labels readable" };
            AuditQuestions question53 = new AuditQuestions { qustionText = "LV pillar / cabinet locks oiled" };
            AuditQuestions question54 = new AuditQuestions { qustionText = "LV pillar/ cabinet painted" };
            AuditQuestions question55 = new AuditQuestions { qustionText = "Substation site/ building left clean and tidy" };
            AuditQuestions question56 = new AuditQuestions { qustionText = "Substation site/ building locks oiled" };
            electricalDistribution.auditQuestionsLst.Add(question37);
            electricalDistribution.auditQuestionsLst.Add(question38);
            electricalDistribution.auditQuestionsLst.Add(question39);
            electricalDistribution.auditQuestionsLst.Add(question40);
            electricalDistribution.auditQuestionsLst.Add(question41);
            electricalDistribution.auditQuestionsLst.Add(question42);
            electricalDistribution.auditQuestionsLst.Add(question43);
            electricalDistribution.auditQuestionsLst.Add(question44);
            electricalDistribution.auditQuestionsLst.Add(question45);
            electricalDistribution.auditQuestionsLst.Add(question46);
            electricalDistribution.auditQuestionsLst.Add(question47);
            electricalDistribution.auditQuestionsLst.Add(question48);
            electricalDistribution.auditQuestionsLst.Add(question49);
            electricalDistribution.auditQuestionsLst.Add(question50);
            electricalDistribution.auditQuestionsLst.Add(question51);
            electricalDistribution.auditQuestionsLst.Add(question52);
            electricalDistribution.auditQuestionsLst.Add(question53);
            electricalDistribution.auditQuestionsLst.Add(question54);
            electricalDistribution.auditQuestionsLst.Add(question55);
            electricalDistribution.auditQuestionsLst.Add(question56);

            //Tools / Equipment  These also include a ‘testing date’ field:
            AuditQuestions question57 = new AuditQuestions { qustionText = "Tester-Scope" };
            AuditQuestions question58 = new AuditQuestions { qustionText = "Phase Rotation Meter" };
            AuditQuestions question59 = new AuditQuestions { qustionText = "Insulation Resistance Tester" };
            AuditQuestions question60 = new AuditQuestions { qustionText = "Multimeter / Voltmeter" };
            AuditQuestions question61 = new AuditQuestions { qustionText = "Earth Loop Impedance Tester" };
            AuditQuestions question62 = new AuditQuestions { qustionText = "Test Lamp" };
            AuditQuestions question63 = new AuditQuestions { qustionText = "Cable Locator" };
            AuditQuestions question64 = new AuditQuestions { qustionText = "Signal Generator" };
            AuditQuestions question65 = new AuditQuestions { qustionText = "Fire Extinguisher 1" };
            AuditQuestions question66 = new AuditQuestions { qustionText = "Fire Extinguisher 2" };
            AuditQuestions question67 = new AuditQuestions { qustionText = "Other1" };
            AuditQuestions question68 = new AuditQuestions { qustionText = "Other2" };
            electricalDistribution.auditQuestionsLst.Add(question57);
            electricalDistribution.auditQuestionsLst.Add(question58);
            electricalDistribution.auditQuestionsLst.Add(question59);
            electricalDistribution.auditQuestionsLst.Add(question60);
            electricalDistribution.auditQuestionsLst.Add(question61);
            electricalDistribution.auditQuestionsLst.Add(question62);
            electricalDistribution.auditQuestionsLst.Add(question63);
            electricalDistribution.auditQuestionsLst.Add(question64);
            electricalDistribution.auditQuestionsLst.Add(question65);
            electricalDistribution.auditQuestionsLst.Add(question66);
            electricalDistribution.auditQuestionsLst.Add(question67);
            electricalDistribution.auditQuestionsLst.Add(question68);

            //Small Tools
            AuditQuestions question69 = new AuditQuestions { qustionText = "Correct Insulated Tools Available" };
            AuditQuestions question70 = new AuditQuestions { qustionText = "Condition of Insulated Tools" };
            electricalDistribution.auditQuestionsLst.Add(question69);
            electricalDistribution.auditQuestionsLst.Add(question70);

            //PPE
            AuditQuestions question71 = new AuditQuestions { qustionText = "Hard Hat" };
            AuditQuestions question72 = new AuditQuestions { qustionText = "Eye Protection" };
            AuditQuestions question73 = new AuditQuestions { qustionText = "Ear Defenders" };
            AuditQuestions question74 = new AuditQuestions { qustionText = "Footwear" };
            AuditQuestions question75 = new AuditQuestions { qustionText = "High Viz" };
            AuditQuestions question76 = new AuditQuestions { qustionText = "Insulated Gloves" };
            AuditQuestions question77 = new AuditQuestions { qustionText = "Dust Masks" };
            AuditQuestions question78 = new AuditQuestions { qustionText = "First Aid Kit" };
            AuditQuestions question79 = new AuditQuestions { qustionText = "Eye Wash" };
            AuditQuestions question80 = new AuditQuestions { qustionText = "Other" };

            electricalDistribution.auditQuestionsLst.Add(question71);
            electricalDistribution.auditQuestionsLst.Add(question72);
            electricalDistribution.auditQuestionsLst.Add(question73);
            electricalDistribution.auditQuestionsLst.Add(question74);
            electricalDistribution.auditQuestionsLst.Add(question75);
            electricalDistribution.auditQuestionsLst.Add(question76);
            electricalDistribution.auditQuestionsLst.Add(question77);
            electricalDistribution.auditQuestionsLst.Add(question78);
            electricalDistribution.auditQuestionsLst.Add(question79);
            electricalDistribution.auditQuestionsLst.Add(question80);

            return View("~/Views/Audit/ElectricalDistributionAudit/ElectricalDistribution.cshtml", electricalDistribution);
        }
        [HttpPost]
        public IActionResult ElectricalDistributionAudit(ElectricalDistribution electricalDistribution)
        {
            //_electricalDistributionRepository.Add(electricalDistribution);
            return View();
        }
    }
}
