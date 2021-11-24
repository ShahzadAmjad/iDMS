using iDMS.Models.Audit;
using iDMS.Models.Audit.GasTechnicalAudit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Controllers.Audit
{
    public class GasTechnicalAuditController : Controller
    {
        private IGasTechnicalRepository _GasTechnicalRepository;
        public GasTechnicalAuditController(IGasTechnicalRepository gasTechnicalRepository)
        {
            _GasTechnicalRepository = gasTechnicalRepository;
        }
        public IActionResult Index()
        {
            return View("~/Views/Audit/GasTechnicalAudit/GasTechnical.cshtml");
        }
        [HttpGet]
        public ViewResult GasTechnicalAudit()
        {
            GasTechnical gasTechnical = new GasTechnical();
            gasTechnical.auditQuestionsLst = new List<AuditQuestions>() { };


            //Documents
            AuditQuestions question1 = new AuditQuestions { qustionText = "Drawing No" };
            AuditQuestions question2 = new AuditQuestions { qustionText = "Jointing instruction / Permit to work" };
            AuditQuestions question3 = new AuditQuestions { qustionText = "Other Utilities drawings" };
            AuditQuestions question4 = new AuditQuestions { qustionText = "Site Specific Risk Assessment" };
            AuditQuestions question5 = new AuditQuestions { qustionText = "Commissioned Mains Drawing" };
            AuditQuestions question6 = new AuditQuestions { qustionText = "Work Instruction" };
            gasTechnical.auditQuestionsLst.Add(question1);
            gasTechnical.auditQuestionsLst.Add(question2);
            gasTechnical.auditQuestionsLst.Add(question3);
            gasTechnical.auditQuestionsLst.Add(question4);
            gasTechnical.auditQuestionsLst.Add(question5);
            gasTechnical.auditQuestionsLst.Add(question6);

            //Excavation 
            AuditQuestions question7 = new AuditQuestions { qustionText = "Excavation Fencing" };
            AuditQuestions question8 = new AuditQuestions { qustionText = "Trench Bed" };
            AuditQuestions question9 = new AuditQuestions { qustionText = "Trench Support" };
            AuditQuestions question10 = new AuditQuestions { qustionText = "Mains Position" };
            AuditQuestions question11 = new AuditQuestions { qustionText = "Mains Insertion" };
            AuditQuestions question12 = new AuditQuestions { qustionText = "Mains Insertion" };
            AuditQuestions question13 = new AuditQuestions { qustionText = "Directional Drill" };
            gasTechnical.auditQuestionsLst.Add(question7);
            gasTechnical.auditQuestionsLst.Add(question8);
            gasTechnical.auditQuestionsLst.Add(question9);
            gasTechnical.auditQuestionsLst.Add(question10);
            gasTechnical.auditQuestionsLst.Add(question11);
            gasTechnical.auditQuestionsLst.Add(question12);
            gasTechnical.auditQuestionsLst.Add(question13);

            //Mains 
            AuditQuestions question14 = new AuditQuestions { qustionText = "Size" };
            AuditQuestions question15 = new AuditQuestions { qustionText = "Depth" };
            AuditQuestions question16 = new AuditQuestions { qustionText = "Location" };
            AuditQuestions question17 = new AuditQuestions { qustionText = "Fusion" };
            AuditQuestions question18 = new AuditQuestions { qustionText = "Test" };
            AuditQuestions question19 = new AuditQuestions { qustionText = "Commission" };
            AuditQuestions question20 = new AuditQuestions { qustionText = "Marker Tape" };
            AuditQuestions question21 = new AuditQuestions { qustionText = "Method Statement" }; //(does not include ‘specify’ field)
            gasTechnical.auditQuestionsLst.Add(question14);
            gasTechnical.auditQuestionsLst.Add(question15);
            gasTechnical.auditQuestionsLst.Add(question16);
            gasTechnical.auditQuestionsLst.Add(question17);
            gasTechnical.auditQuestionsLst.Add(question18);
            gasTechnical.auditQuestionsLst.Add(question19);
            gasTechnical.auditQuestionsLst.Add(question20);
            gasTechnical.auditQuestionsLst.Add(question21);

            //Services  

            AuditQuestions question22 = new AuditQuestions { qustionText = "Size" };
            AuditQuestions question23 = new AuditQuestions { qustionText = "Depth" };
            AuditQuestions question24 = new AuditQuestions { qustionText = "Developer Ducts" };
            AuditQuestions question25 = new AuditQuestions { qustionText = "Material" };
            AuditQuestions question26 = new AuditQuestions { qustionText = "Test" };
            AuditQuestions question27 = new AuditQuestions { qustionText = "Commission" };
            AuditQuestions question28 = new AuditQuestions { qustionText = "Method Statement" }; //(does not include ‘specify’ field)
            gasTechnical.auditQuestionsLst.Add(question18);
            gasTechnical.auditQuestionsLst.Add(question19);
            gasTechnical.auditQuestionsLst.Add(question20);
            gasTechnical.auditQuestionsLst.Add(question21);
            gasTechnical.auditQuestionsLst.Add(question22);
            gasTechnical.auditQuestionsLst.Add(question23);
            gasTechnical.auditQuestionsLst.Add(question24);
            gasTechnical.auditQuestionsLst.Add(question25);
            gasTechnical.auditQuestionsLst.Add(question26);
            gasTechnical.auditQuestionsLst.Add(question27);
            gasTechnical.auditQuestionsLst.Add(question28);

            //	Connection/Parent Main 
            AuditQuestions question29 = new AuditQuestions { qustionText = "Size" };
            AuditQuestions question30 = new AuditQuestions { qustionText = "Depth" };
            AuditQuestions question31 = new AuditQuestions { qustionText = "Material" };
            AuditQuestions question32 = new AuditQuestions { qustionText = "Connection type" };
            AuditQuestions question33 = new AuditQuestions { qustionText = "Method Statement" };
            gasTechnical.auditQuestionsLst.Add(question29);
            gasTechnical.auditQuestionsLst.Add(question30);
            gasTechnical.auditQuestionsLst.Add(question31);
            gasTechnical.auditQuestionsLst.Add(question32);
            gasTechnical.auditQuestionsLst.Add(question33);

            //Jointing 
            AuditQuestions question34 = new AuditQuestions { qustionText = "Butt Fusion Print out" };
            AuditQuestions question35 = new AuditQuestions { qustionText = "Butt fusion Bead" };
            AuditQuestions question36 = new AuditQuestions { qustionText = "E/F nipple" };
            AuditQuestions question37 = new AuditQuestions { qustionText = "E/F scraping" };        
            gasTechnical.auditQuestionsLst.Add(question34);
            gasTechnical.auditQuestionsLst.Add(question35);
            gasTechnical.auditQuestionsLst.Add(question36);
            gasTechnical.auditQuestionsLst.Add(question37);

            //o	Tools & Equipment 
            AuditQuestions question38 = new AuditQuestions { qustionText = "Breathing Apparatus x 2" };
            AuditQuestions question39 = new AuditQuestions { qustionText = "Gascoseeker" };
            AuditQuestions question40 = new AuditQuestions { qustionText = "Cable Locator" };
            AuditQuestions question41 = new AuditQuestions { qustionText = "Fire Extinguisher 1" };
            AuditQuestions question42 = new AuditQuestions { qustionText = "Fire Extinguisher 2" };
            AuditQuestions question43 = new AuditQuestions { qustionText = "Pressure Gauges" };
            AuditQuestions question44 = new AuditQuestions { qustionText = "First aid kit" };
            AuditQuestions question45 = new AuditQuestions { qustionText = "Eye Wash" };
            AuditQuestions question46 = new AuditQuestions { qustionText = "Continuity Bond" };
            AuditQuestions question47 = new AuditQuestions { qustionText = "Purge Hose" };
            AuditQuestions question48 = new AuditQuestions { qustionText = "Butt fusion M/C" };
            AuditQuestions question49 = new AuditQuestions { qustionText = "Electro Fusion M/C" };
            AuditQuestions question50 = new AuditQuestions { qustionText = "Van" };
            gasTechnical.auditQuestionsLst.Add(question38);
            gasTechnical.auditQuestionsLst.Add(question39);
            gasTechnical.auditQuestionsLst.Add(question40);
            gasTechnical.auditQuestionsLst.Add(question41);
            gasTechnical.auditQuestionsLst.Add(question42);
            gasTechnical.auditQuestionsLst.Add(question43);
            gasTechnical.auditQuestionsLst.Add(question44);
            gasTechnical.auditQuestionsLst.Add(question45);
            gasTechnical.auditQuestionsLst.Add(question46);
            gasTechnical.auditQuestionsLst.Add(question47);
            gasTechnical.auditQuestionsLst.Add(question48);
            gasTechnical.auditQuestionsLst.Add(question49);
            gasTechnical.auditQuestionsLst.Add(question50);

            //o	Accreditation 
            AuditQuestions question51 = new AuditQuestions { qustionText = "GWINTO/ EUS Card" };
            AuditQuestions question52 = new AuditQuestions { qustionText = "Team Leader" };
            AuditQuestions question53 = new AuditQuestions { qustionText = "Mate" };
            AuditQuestions question54 = new AuditQuestions { qustionText = "Gas Network Safety Passport" };
            AuditQuestions question55 = new AuditQuestions { qustionText = "Team Leader" };
            AuditQuestions question56 = new AuditQuestions { qustionText = "Mate" };
            gasTechnical.auditQuestionsLst.Add(question51);
            gasTechnical.auditQuestionsLst.Add(question52);
            gasTechnical.auditQuestionsLst.Add(question53);
            gasTechnical.auditQuestionsLst.Add(question54);
            gasTechnical.auditQuestionsLst.Add(question55);
            gasTechnical.auditQuestionsLst.Add(question56);

            //o	Testing 

            AuditQuestions question57 = new AuditQuestions { qustionText = "Duration" };
            AuditQuestions question58 = new AuditQuestions { qustionText = "Pressure" };
            AuditQuestions question59 = new AuditQuestions { qustionText = "Allowed Drop" };

            gasTechnical.auditQuestionsLst.Add(question57);
            gasTechnical.auditQuestionsLst.Add(question58);
            gasTechnical.auditQuestionsLst.Add(question59);

            //Commissioning 
            AuditQuestions question60 = new AuditQuestions { qustionText = "Purge volume" };
            AuditQuestions question61 = new AuditQuestions { qustionText = "Purge duration" };
            AuditQuestions question62 = new AuditQuestions { qustionText = "Size of rider" };
            AuditQuestions question63 = new AuditQuestions { qustionText = "Size of vent" };
            gasTechnical.auditQuestionsLst.Add(question60);
            gasTechnical.auditQuestionsLst.Add(question61);
            gasTechnical.auditQuestionsLst.Add(question62);
            gasTechnical.auditQuestionsLst.Add(question63);
            
            //PPE
            AuditQuestions question64 = new AuditQuestions { qustionText = "Hard Hat" };
            AuditQuestions question65 = new AuditQuestions { qustionText = "Eye Protection" };
            AuditQuestions question66 = new AuditQuestions { qustionText = "Ear Defenders" };
            AuditQuestions question67 = new AuditQuestions { qustionText = "Flame Retardant Coverall" };
            AuditQuestions question68 = new AuditQuestions { qustionText = "Footwear" };
            AuditQuestions question69 = new AuditQuestions { qustionText = "High viz" };
            AuditQuestions question70 = new AuditQuestions { qustionText = "Gloves" };
            gasTechnical.auditQuestionsLst.Add(question64);
            gasTechnical.auditQuestionsLst.Add(question65);
            gasTechnical.auditQuestionsLst.Add(question66);
            gasTechnical.auditQuestionsLst.Add(question67);
            gasTechnical.auditQuestionsLst.Add(question68);
            gasTechnical.auditQuestionsLst.Add(question69);
            gasTechnical.auditQuestionsLst.Add(question70);

            return View("~/Views/Audit/GasTechnicalAudit/GasTechnical.cshtml", gasTechnical);
        }
        [HttpPost]
        public IActionResult GasTechnicalAudit(GasTechnical gasTechnical)
        {
            _GasTechnicalRepository.Add(gasTechnical);
            return View("~/Views/Audit/GasTechnicalAudit/GasTechnical.cshtml");
        }
    }
}
