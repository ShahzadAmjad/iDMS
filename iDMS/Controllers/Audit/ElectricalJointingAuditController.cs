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
        private IElectricalJointingRepository _electricalJointingRepository;
        public ElectricalJointingAuditController(IElectricalJointingRepository electricalJointingRepository)
        {
            _electricalJointingRepository = electricalJointingRepository;
        }
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
            AuditQuestions question60 = new AuditQuestions { qustionText = "Tester-Scope" };
            AuditQuestions question61 = new AuditQuestions { qustionText = "Phase Rotation Meter" };
            AuditQuestions question62 = new AuditQuestions { qustionText = "Phase Rotation Meter" };
            AuditQuestions question63 = new AuditQuestions { qustionText = "Insulation Resistance Tester" };
            AuditQuestions question64 = new AuditQuestions { qustionText = "Multimeter/ Voltmeter" };
            AuditQuestions question65 = new AuditQuestions { qustionText = "Earth Loop Impedance Tester" };
            AuditQuestions question66 = new AuditQuestions { qustionText = "Test Lamp" };
            AuditQuestions question67 = new AuditQuestions { qustionText = "Cable Locator" };
            AuditQuestions question68 = new AuditQuestions { qustionText = "Signal Generator" };
            AuditQuestions question69 = new AuditQuestions { qustionText = "Fire Extinguisher 1" };
            AuditQuestions question70 = new AuditQuestions { qustionText = "Fire Extinguisher 2" };
            AuditQuestions question71 = new AuditQuestions { qustionText = "Other" };
            electricalJointing.auditQuestionsLst.Add(question60);
            electricalJointing.auditQuestionsLst.Add(question61);
            electricalJointing.auditQuestionsLst.Add(question62);
            electricalJointing.auditQuestionsLst.Add(question63);
            electricalJointing.auditQuestionsLst.Add(question64);
            electricalJointing.auditQuestionsLst.Add(question65);
            electricalJointing.auditQuestionsLst.Add(question66);
            electricalJointing.auditQuestionsLst.Add(question67);
            electricalJointing.auditQuestionsLst.Add(question68);
            electricalJointing.auditQuestionsLst.Add(question69);
            electricalJointing.auditQuestionsLst.Add(question70);
            electricalJointing.auditQuestionsLst.Add(question71);

            //Small Tools 
            AuditQuestions question72 = new AuditQuestions { qustionText = "Correct Tools Available" };
            AuditQuestions question73 = new AuditQuestions { qustionText = "Condition of Tools" };
            electricalJointing.auditQuestionsLst.Add(question72);
            electricalJointing.auditQuestionsLst.Add(question73);

            //PPE  
            AuditQuestions question74 = new AuditQuestions { qustionText = "Hard Hat" };
            AuditQuestions question75 = new AuditQuestions { qustionText = "Eye Protection" };
            AuditQuestions question76 = new AuditQuestions { qustionText = "Ear Defenders" };
            AuditQuestions question77 = new AuditQuestions { qustionText = "Flame Retardant Coverall" };
            AuditQuestions question78 = new AuditQuestions { qustionText = "Footwear" };
            AuditQuestions question79 = new AuditQuestions { qustionText = "High Viz" };
            AuditQuestions question80 = new AuditQuestions { qustionText = "Gloves" };
            AuditQuestions question81 = new AuditQuestions { qustionText = "Dust Masks" };
            AuditQuestions question82 = new AuditQuestions { qustionText = "First Aid Kit" };
            AuditQuestions question83 = new AuditQuestions { qustionText = "Eye Wash" };
            AuditQuestions question84 = new AuditQuestions { qustionText = "Other" };
            electricalJointing.auditQuestionsLst.Add(question74);
            electricalJointing.auditQuestionsLst.Add(question75);
            electricalJointing.auditQuestionsLst.Add(question76);
            electricalJointing.auditQuestionsLst.Add(question77);
            electricalJointing.auditQuestionsLst.Add(question78);
            electricalJointing.auditQuestionsLst.Add(question79);
            electricalJointing.auditQuestionsLst.Add(question80);
            electricalJointing.auditQuestionsLst.Add(question81);
            electricalJointing.auditQuestionsLst.Add(question82);
            electricalJointing.auditQuestionsLst.Add(question83);
            electricalJointing.auditQuestionsLst.Add(question84);

            //
            //Substation Maintenance
            AuditQuestions question85 = new AuditQuestions { qustionText = "Correct modification information available" };
            AuditQuestions question86 = new AuditQuestions { qustionText = "Correct modification being carried out" };
            AuditQuestions question87 = new AuditQuestions { qustionText = "Repeatable modifications being carried out" };
            AuditQuestions question88 = new AuditQuestions { qustionText = "Exposed internal components protected from the elements" };
            AuditQuestions question89 = new AuditQuestions { qustionText = "PRM label fitted" };
            AuditQuestions question90 = new AuditQuestions { qustionText = "Switchgear clean" };
            AuditQuestions question91 = new AuditQuestions { qustionText = "Switchgear locks oiled" };
            AuditQuestions question92 = new AuditQuestions { qustionText = "Switchgear patch painted" };
            AuditQuestions question93 = new AuditQuestions { qustionText = "Switchgear circuit labels readable" };
            AuditQuestions question94 = new AuditQuestions { qustionText = "Switchgear oil leaks" };
            AuditQuestions question95 = new AuditQuestions { qustionText = "Transformer clean" };
            AuditQuestions question96 = new AuditQuestions { qustionText = "Transformer locks oiled" };
            AuditQuestions question97 = new AuditQuestions { qustionText = "Transformer patch painted" };
            AuditQuestions question98 = new AuditQuestions { qustionText = "LV pillar / cabinet cleaned inside" };
            AuditQuestions question99 = new AuditQuestions { qustionText = "LV pillar / cabinet cleaned outside" };
            AuditQuestions question100 = new AuditQuestions { qustionText = "LV pillar / cabinet circuit labels readable" };
            AuditQuestions question101 = new AuditQuestions { qustionText = "LV pillar / cabinet locks oiled" };
            AuditQuestions question102 = new AuditQuestions { qustionText = "LV pillar/ cabinet painted" };
            AuditQuestions question103 = new AuditQuestions { qustionText = "Substation site/ building left clean and tidy" };
            AuditQuestions question104 = new AuditQuestions { qustionText = "Substation site/ building locks oiled" };
            electricalJointing.auditQuestionsLst.Add(question85);
            electricalJointing.auditQuestionsLst.Add(question86);
            electricalJointing.auditQuestionsLst.Add(question87);
            electricalJointing.auditQuestionsLst.Add(question88);
            electricalJointing.auditQuestionsLst.Add(question89);
            electricalJointing.auditQuestionsLst.Add(question90);
            electricalJointing.auditQuestionsLst.Add(question91);
            electricalJointing.auditQuestionsLst.Add(question92);
            electricalJointing.auditQuestionsLst.Add(question93);
            electricalJointing.auditQuestionsLst.Add(question94);
            electricalJointing.auditQuestionsLst.Add(question95);
            electricalJointing.auditQuestionsLst.Add(question96);
            electricalJointing.auditQuestionsLst.Add(question97);
            electricalJointing.auditQuestionsLst.Add(question98);
            electricalJointing.auditQuestionsLst.Add(question99);
            electricalJointing.auditQuestionsLst.Add(question100);
            electricalJointing.auditQuestionsLst.Add(question101);
            electricalJointing.auditQuestionsLst.Add(question102);
            electricalJointing.auditQuestionsLst.Add(question103);
            electricalJointing.auditQuestionsLst.Add(question104);
            
            //Craftsman Low Voltage Understanding 
            AuditQuestions question105 = new AuditQuestions { qustionText = "Polarity and phase rotation" };
            AuditQuestions question106 = new AuditQuestions { qustionText = "Points of Isolation" };
            AuditQuestions question107= new AuditQuestions { qustionText = "Supply Point" };
            AuditQuestions question108 = new AuditQuestions { qustionText = "Phasing Out-Link Box, Pillar, etc." };
            AuditQuestions question109 = new AuditQuestions { qustionText = "Discrimination" };
            AuditQuestions question110 = new AuditQuestions { qustionText = "PME" };
            AuditQuestions question111 = new AuditQuestions { qustionText = "LV Diagram" };
            AuditQuestions question112 = new AuditQuestions { qustionText = "Earth Loop Impedance" };
            electricalJointing.auditQuestionsLst.Add(question105);
            electricalJointing.auditQuestionsLst.Add(question106);
            electricalJointing.auditQuestionsLst.Add(question107);
            electricalJointing.auditQuestionsLst.Add(question108);
            electricalJointing.auditQuestionsLst.Add(question109);
            electricalJointing.auditQuestionsLst.Add(question110);
            electricalJointing.auditQuestionsLst.Add(question111);
            electricalJointing.auditQuestionsLst.Add(question112);


            return View("~/Views/Audit/ElectricalJointingAudit/ElectricalJointing.cshtml", electricalJointing);
        }
        [HttpPost]
        public IActionResult ElectricalJointingAudit(ElectricalJointing electricalJointing)
        {
            _electricalJointingRepository.Add(electricalJointing);
            return View("~/Views/Home/Home.cshtml");
        }
    }
}
