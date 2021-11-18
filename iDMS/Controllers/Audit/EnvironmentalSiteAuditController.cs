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

            AuditQuestions question1 = new AuditQuestions { qustionText = "Vehicle kept in a clean and tidy condition", ansawer = "No evidence of compliance" };
            AuditQuestions question2 = new AuditQuestions { qustionText = "Vehicles parked away from drains and / or watercourses", ansawer = "No evidence of compliance" };
            AuditQuestions question3 = new AuditQuestions { qustionText = "Vehicle in good condition with no leaks? (oil, anti-freeze etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question4 = new AuditQuestions { qustionText = "(Water, Diesel, 2-Stroke etc) Maximum of two 20 litre cans per van (diesel)", ansawer = "No evidence of compliance" };
            AuditQuestions question5 = new AuditQuestions { qustionText = "Fuel stored in secure containers", ansawer = "No evidence of compliance" };
            AuditQuestions question6 = new AuditQuestions { qustionText = "Fuel cans stored in bunded area / drip trays", ansawer = "No evidence of compliance" };
            environmentalSite.auditQuestionsLst.Add(question1);
            environmentalSite.auditQuestionsLst.Add(question2);
            environmentalSite.auditQuestionsLst.Add(question3);
            environmentalSite.auditQuestionsLst.Add(question4);
            environmentalSite.auditQuestionsLst.Add(question5);
            environmentalSite.auditQuestionsLst.Add(question6);

            //Audit questions plant
            AuditQuestions question7 = new AuditQuestions { qustionText = "Plant in good condition with no leaks", ansawer = "No evidence of compliance" };
            AuditQuestions question8 = new AuditQuestions { qustionText = "Weekly plant inspections being carried out and recorded", ansawer = "No evidence of compliance" };
            AuditQuestions question9 = new AuditQuestions { qustionText = "Plant refuelled without risk to the environment (drains, trees, drip trays)", ansawer = "No evidence of compliance" };
            AuditQuestions question10 = new AuditQuestions { qustionText = "Drip trays being used under compressors", ansawer = "No evidence of compliance" };
            AuditQuestions question11 = new AuditQuestions { qustionText = "Plant turned off when unattended and not in use", ansawer = "No evidence of compliance" };
            AuditQuestions question12 = new AuditQuestions { qustionText = "Plant parked away from drains and / or watercourses", ansawer = "No evidence of compliance" };
            AuditQuestions question13 = new AuditQuestions { qustionText = "Plant not emitting excessive noise, vibration, dust, fumes, exhaust smoke", ansawer = "No evidence of compliance" };
            environmentalSite.auditQuestionsLst.Add(question7);
            environmentalSite.auditQuestionsLst.Add(question8);
            environmentalSite.auditQuestionsLst.Add(question9);
            environmentalSite.auditQuestionsLst.Add(question10);
            environmentalSite.auditQuestionsLst.Add(question11);
            environmentalSite.auditQuestionsLst.Add(question12);
            environmentalSite.auditQuestionsLst.Add(question13);

            //Audit questions Housekeeping 
            AuditQuestions question14 = new AuditQuestions { qustionText = "Site delivery of materials (away from drains, watercourses, excavations etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question15 = new AuditQuestions { qustionText = "Site clear of rubbish (swept and cleared, litter, packaging etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question16= new AuditQuestions { qustionText = "Site clear of spill hazards", ansawer = "No evidence of compliance" };         
            environmentalSite.auditQuestionsLst.Add(question14);
            environmentalSite.auditQuestionsLst.Add(question15);
            environmentalSite.auditQuestionsLst.Add(question16);

            //Audit questions COSHH
            AuditQuestions question17 = new AuditQuestions { qustionText = "Chemicals in correctly labelled containers", ansawer = "No evidence of compliance" };
            AuditQuestions question18 = new AuditQuestions { qustionText = "COSHH assessments available for all hazardous substances (check team pack)", ansawer = "No evidence of compliance" };
            AuditQuestions question19= new AuditQuestions { qustionText = "Spill kit readily available and complete", ansawer = "No evidence of compliance" };
            AuditQuestions question20 = new AuditQuestions { qustionText = "Dust suppression equipment being used", ansawer = "No evidence of compliance" };
            AuditQuestions question21 = new AuditQuestions { qustionText = "Fuel tanks on site bunded (bowsers)", ansawer = "No evidence of compliance" };
            AuditQuestions question22 = new AuditQuestions { qustionText = "No signs of spillages (stains on ground)", ansawer = "No evidence of compliance" };
            environmentalSite.auditQuestionsLst.Add(question17);
            environmentalSite.auditQuestionsLst.Add(question18);
            environmentalSite.auditQuestionsLst.Add(question19);
            environmentalSite.auditQuestionsLst.Add(question20);
            environmentalSite.auditQuestionsLst.Add(question21);
            environmentalSite.auditQuestionsLst.Add(question22);

            //Audit questions Spoil
            AuditQuestions question23 = new AuditQuestions { qustionText = "Spoil separated (tarmac, concrete, other)", ansawer = "No evidence of compliance" };
            AuditQuestions question24 = new AuditQuestions { qustionText = "Spoil stored away from drains / watercourses etc", ansawer = "No evidence of compliance" };
            AuditQuestions question25 = new AuditQuestions { qustionText = "No signs of contamination (colour, appearance, odour)", ansawer = "No evidence of compliance" };
            environmentalSite.auditQuestionsLst.Add(question23);
            environmentalSite.auditQuestionsLst.Add(question24);
            environmentalSite.auditQuestionsLst.Add(question25);

            //Audit questions Spoil
            AuditQuestions question26 = new AuditQuestions { qustionText = "Environmental Risk Assessment available on site", ansawer = "No evidence of compliance" };
            AuditQuestions question27 = new AuditQuestions { qustionText = "Works have minimal / no impact on third parties (public, schools, other contractors etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question28 = new AuditQuestions { qustionText = "Third party activities have no impact on our work (noise, dust, water, leaking machinery etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question29 = new AuditQuestions { qustionText = "All environmental incidents reported", ansawer = "No evidence of compliance" };
            AuditQuestions question30 = new AuditQuestions { qustionText = "Survey of surrounding area undertaken (trees, hedgerows, grass verges, wildlife, nests badgers etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question31 = new AuditQuestions { qustionText = "Water pumped from excavations to surface water drainage or onto ground", ansawer = "No evidence of compliance" };
            AuditQuestions question32 = new AuditQuestions { qustionText = "No evidence of fires or burnt rubbish", ansawer = "No evidence of compliance" };
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
