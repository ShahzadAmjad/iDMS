using iDMS.Models.Audit;
using iDMS.Models.Audit.EnvironmentalSiteAudit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Controllers.Audit
{
    public class EnvironmentalSiteAuditController : Controller
    {
        private IEnvironmentalSiteRepository _environmentalSiteRepository;
        public EnvironmentalSiteAuditController(IEnvironmentalSiteRepository environmentalSiteRepository)
        {
            _environmentalSiteRepository = environmentalSiteRepository;
        }
        public IActionResult Index()
        {
            return View("~/Views/Audit/EnvironmentalSiteAudit/EnvironmentalSite.cshtml");
        }
        [HttpGet]
        public ViewResult EnvironmentalSiteAudit()
        {
            EnvironmentalSite environmentalSite = new EnvironmentalSite();

            environmentalSite.auditQuestionsLst = new List<AuditQuestions>() { };
            //Audit questions Vehicle

            AuditQuestions question1 = new AuditQuestions { qustionText = "Vehicle kept in a clean and tidy condition" };
            AuditQuestions question2 = new AuditQuestions { qustionText = "Vehicles parked away from drains and / or watercourses" };
            AuditQuestions question3 = new AuditQuestions { qustionText = "Vehicle in good condition with no leaks? (oil, anti-freeze etc)"};
            AuditQuestions question4 = new AuditQuestions { qustionText = "(Water, Diesel, 2-Stroke etc) Maximum of two 20 litre cans per van (diesel)"};
            AuditQuestions question5 = new AuditQuestions { qustionText = "Fuel stored in secure containers" };
            AuditQuestions question6 = new AuditQuestions { qustionText = "Fuel cans stored in bunded area / drip trays" };
            environmentalSite.auditQuestionsLst.Add(question1);
            environmentalSite.auditQuestionsLst.Add(question2);
            environmentalSite.auditQuestionsLst.Add(question3);
            environmentalSite.auditQuestionsLst.Add(question4);
            environmentalSite.auditQuestionsLst.Add(question5);
            environmentalSite.auditQuestionsLst.Add(question6);

            //Audit questions plant
            AuditQuestions question7 = new AuditQuestions { qustionText = "Plant in good condition with no leaks"};
            AuditQuestions question8 = new AuditQuestions { qustionText = "Weekly plant inspections being carried out and recorded" };
            AuditQuestions question9 = new AuditQuestions { qustionText = "Plant refuelled without risk to the environment (drains, trees, drip trays)" };
            AuditQuestions question10 = new AuditQuestions { qustionText = "Drip trays being used under compressors" };
            AuditQuestions question11 = new AuditQuestions { qustionText = "Plant turned off when unattended and not in use" };
            AuditQuestions question12 = new AuditQuestions { qustionText = "Plant parked away from drains and / or watercourses" };
            AuditQuestions question13 = new AuditQuestions { qustionText = "Plant not emitting excessive noise, vibration, dust, fumes, exhaust smoke"};
            environmentalSite.auditQuestionsLst.Add(question7);
            environmentalSite.auditQuestionsLst.Add(question8);
            environmentalSite.auditQuestionsLst.Add(question9);
            environmentalSite.auditQuestionsLst.Add(question10);
            environmentalSite.auditQuestionsLst.Add(question11);
            environmentalSite.auditQuestionsLst.Add(question12);
            environmentalSite.auditQuestionsLst.Add(question13);

            //Audit questions Housekeeping 
            AuditQuestions question14 = new AuditQuestions { qustionText = "Site delivery of materials (away from drains, watercourses, excavations etc)" };
            AuditQuestions question15 = new AuditQuestions { qustionText = "Site clear of rubbish (swept and cleared, litter, packaging etc)"};
            AuditQuestions question16= new AuditQuestions { qustionText = "Site clear of spill hazards"};         
            environmentalSite.auditQuestionsLst.Add(question14);
            environmentalSite.auditQuestionsLst.Add(question15);
            environmentalSite.auditQuestionsLst.Add(question16);

            //Audit questions COSHH
            AuditQuestions question17 = new AuditQuestions { qustionText = "Chemicals in correctly labelled containers" };
            AuditQuestions question18 = new AuditQuestions { qustionText = "COSHH assessments available for all hazardous substances (check team pack)" };
            AuditQuestions question19= new AuditQuestions { qustionText = "Spill kit readily available and complete", ansawer = "" };
            AuditQuestions question20 = new AuditQuestions { qustionText = "Dust suppression equipment being used", ansawer = "" };
            AuditQuestions question21 = new AuditQuestions { qustionText = "Fuel tanks on site bunded (bowsers)", ansawer = "" };
            AuditQuestions question22 = new AuditQuestions { qustionText = "No signs of spillages (stains on ground)", ansawer = "" };
            environmentalSite.auditQuestionsLst.Add(question17);
            environmentalSite.auditQuestionsLst.Add(question18);
            environmentalSite.auditQuestionsLst.Add(question19);
            environmentalSite.auditQuestionsLst.Add(question20);
            environmentalSite.auditQuestionsLst.Add(question21);
            environmentalSite.auditQuestionsLst.Add(question22);

            //Audit questions Spoil
            AuditQuestions question23 = new AuditQuestions { qustionText = "Spoil separated (tarmac, concrete, other)", ansawer = "" };
            AuditQuestions question24 = new AuditQuestions { qustionText = "Spoil stored away from drains / watercourses etc", ansawer = "" };
            AuditQuestions question25 = new AuditQuestions { qustionText = "No signs of contamination (colour, appearance, odour)", ansawer = "" };
            environmentalSite.auditQuestionsLst.Add(question23);
            environmentalSite.auditQuestionsLst.Add(question24);
            environmentalSite.auditQuestionsLst.Add(question25);

            //Audit questions Spoil
            AuditQuestions question26 = new AuditQuestions { qustionText = "Environmental Risk Assessment available on site", ansawer = "" };
            AuditQuestions question27 = new AuditQuestions { qustionText = "Works have minimal / no impact on third parties (public, schools, other contractors etc)", ansawer = "" };
            AuditQuestions question28 = new AuditQuestions { qustionText = "Third party activities have no impact on our work (noise, dust, water, leaking machinery etc)", ansawer = "" };
            AuditQuestions question29 = new AuditQuestions { qustionText = "All environmental incidents reported", ansawer = "" };
            AuditQuestions question30 = new AuditQuestions { qustionText = "Survey of surrounding area undertaken (trees, hedgerows, grass verges, wildlife, nests badgers etc)", ansawer = "" };
            AuditQuestions question31 = new AuditQuestions { qustionText = "Water pumped from excavations to surface water drainage or onto ground", ansawer = "" };
            AuditQuestions question32 = new AuditQuestions { qustionText = "No evidence of fires or burnt rubbish", ansawer = "" };
            environmentalSite.auditQuestionsLst.Add(question26);
            environmentalSite.auditQuestionsLst.Add(question27);
            environmentalSite.auditQuestionsLst.Add(question28);
            environmentalSite.auditQuestionsLst.Add(question29);
            environmentalSite.auditQuestionsLst.Add(question30);
            environmentalSite.auditQuestionsLst.Add(question31);
            environmentalSite.auditQuestionsLst.Add(question32);

            return View("~/Views/Audit/EnvironmentalSiteAudit/EnvironmentalSite.cshtml", environmentalSite);
        }
        [HttpPost]
        public IActionResult EnvironmentalSiteAudit(EnvironmentalSite environmentalSite)
        {
            _environmentalSiteRepository.Add(environmentalSite);
            return View("~/Views/Home/Home.cshtml");
        }
    }
}
