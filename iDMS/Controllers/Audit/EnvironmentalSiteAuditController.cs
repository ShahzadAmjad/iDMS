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


            //Audit questions Vehicle
            environmentalSite.auditQuestionsVehiclesLst = new List<AuditQuestions>() { };
            AuditQuestions question1 = new AuditQuestions { qustionText = "Vehicle kept in a clean and tidy condition", ansawer = "No evidence of compliance" };
            AuditQuestions question2 = new AuditQuestions { qustionText = "Vehicles parked away from drains and / or watercourses", ansawer = "No evidence of compliance" };
            AuditQuestions question3 = new AuditQuestions { qustionText = "Vehicle in good condition with no leaks? (oil, anti-freeze etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question4 = new AuditQuestions { qustionText = "(Water, Diesel, 2-Stroke etc) Maximum of two 20 litre cans per van (diesel)", ansawer = "No evidence of compliance" };
            AuditQuestions question5 = new AuditQuestions { qustionText = "Fuel stored in secure containers", ansawer = "No evidence of compliance" };
            AuditQuestions question6 = new AuditQuestions { qustionText = "Fuel cans stored in bunded area / drip trays", ansawer = "No evidence of compliance" };
            environmentalSite.auditQuestionsVehiclesLst.Add(question1);
            environmentalSite.auditQuestionsVehiclesLst.Add(question2);
            environmentalSite.auditQuestionsVehiclesLst.Add(question3);
            environmentalSite.auditQuestionsVehiclesLst.Add(question4);
            environmentalSite.auditQuestionsVehiclesLst.Add(question5);
            environmentalSite.auditQuestionsVehiclesLst.Add(question6);

            //Audit questions plant
            environmentalSite.auditQuestionsPlantLst = new List<AuditQuestions>() { };
            AuditQuestions question7 = new AuditQuestions { qustionText = "Plant in good condition with no leaks", ansawer = "No evidence of compliance" };
            AuditQuestions question8 = new AuditQuestions { qustionText = "Weekly plant inspections being carried out and recorded", ansawer = "No evidence of compliance" };
            AuditQuestions question9 = new AuditQuestions { qustionText = "Plant refuelled without risk to the environment (drains, trees, drip trays)", ansawer = "No evidence of compliance" };
            AuditQuestions question10 = new AuditQuestions { qustionText = "Drip trays being used under compressors", ansawer = "No evidence of compliance" };
            AuditQuestions question11 = new AuditQuestions { qustionText = "Plant turned off when unattended and not in use", ansawer = "No evidence of compliance" };
            AuditQuestions question12 = new AuditQuestions { qustionText = "Plant parked away from drains and / or watercourses", ansawer = "No evidence of compliance" };
            AuditQuestions question13 = new AuditQuestions { qustionText = "Plant not emitting excessive noise, vibration, dust, fumes, exhaust smoke", ansawer = "No evidence of compliance" };
            environmentalSite.auditQuestionsPlantLst.Add(question7);
            environmentalSite.auditQuestionsPlantLst.Add(question8);
            environmentalSite.auditQuestionsPlantLst.Add(question9);
            environmentalSite.auditQuestionsPlantLst.Add(question10);
            environmentalSite.auditQuestionsPlantLst.Add(question11);
            environmentalSite.auditQuestionsPlantLst.Add(question12);
            environmentalSite.auditQuestionsPlantLst.Add(question13);

            //Audit questions Housekeeping 
            environmentalSite.auditQuestionsHouseKeeepingLst = new List<AuditQuestions>() { };
            AuditQuestions question14 = new AuditQuestions { qustionText = "Site delivery of materials (away from drains, watercourses, excavations etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question15 = new AuditQuestions { qustionText = "Site clear of rubbish (swept and cleared, litter, packaging etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question16= new AuditQuestions { qustionText = "Site clear of spill hazards", ansawer = "No evidence of compliance" };         
            environmentalSite.auditQuestionsHouseKeeepingLst.Add(question14);
            environmentalSite.auditQuestionsHouseKeeepingLst.Add(question15);
            environmentalSite.auditQuestionsHouseKeeepingLst.Add(question16);

            //Audit questions COSHH
            environmentalSite.auditQuestionsCOSHHLst = new List<AuditQuestions>() { };
            AuditQuestions question17 = new AuditQuestions { qustionText = "Chemicals in correctly labelled containers", ansawer = "No evidence of compliance" };
            AuditQuestions question18 = new AuditQuestions { qustionText = "COSHH assessments available for all hazardous substances (check team pack)", ansawer = "No evidence of compliance" };
            AuditQuestions question19= new AuditQuestions { qustionText = "Spill kit readily available and complete", ansawer = "No evidence of compliance" };
            AuditQuestions question20 = new AuditQuestions { qustionText = "Dust suppression equipment being used", ansawer = "No evidence of compliance" };
            AuditQuestions question21 = new AuditQuestions { qustionText = "Fuel tanks on site bunded (bowsers)", ansawer = "No evidence of compliance" };
            AuditQuestions question22 = new AuditQuestions { qustionText = "No signs of spillages (stains on ground)", ansawer = "No evidence of compliance" };
            environmentalSite.auditQuestionsCOSHHLst.Add(question17);
            environmentalSite.auditQuestionsCOSHHLst.Add(question18);
            environmentalSite.auditQuestionsCOSHHLst.Add(question19);
            environmentalSite.auditQuestionsCOSHHLst.Add(question20);
            environmentalSite.auditQuestionsCOSHHLst.Add(question21);
            environmentalSite.auditQuestionsCOSHHLst.Add(question22);

            //Audit questions Spoil
            environmentalSite.auditQuestionsSpoilLst = new List<AuditQuestions>() { };
            AuditQuestions question23 = new AuditQuestions { qustionText = "Spoil separated (tarmac, concrete, other)", ansawer = "No evidence of compliance" };
            AuditQuestions question24 = new AuditQuestions { qustionText = "Spoil stored away from drains / watercourses etc", ansawer = "No evidence of compliance" };
            AuditQuestions question25 = new AuditQuestions { qustionText = "No signs of contamination (colour, appearance, odour)", ansawer = "No evidence of compliance" };
            environmentalSite.auditQuestionsSpoilLst.Add(question23);
            environmentalSite.auditQuestionsSpoilLst.Add(question24);
            environmentalSite.auditQuestionsSpoilLst.Add(question25);




            //Audit questions Spoil
            environmentalSite.auditQuestionsOthersLst = new List<AuditQuestions>() { };
            AuditQuestions question26 = new AuditQuestions { qustionText = "Environmental Risk Assessment available on site", ansawer = "No evidence of compliance" };
            AuditQuestions question27 = new AuditQuestions { qustionText = "Works have minimal / no impact on third parties (public, schools, other contractors etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question28 = new AuditQuestions { qustionText = "Third party activities have no impact on our work (noise, dust, water, leaking machinery etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question29 = new AuditQuestions { qustionText = "All environmental incidents reported", ansawer = "No evidence of compliance" };
            AuditQuestions question30 = new AuditQuestions { qustionText = "Survey of surrounding area undertaken (trees, hedgerows, grass verges, wildlife, nests badgers etc)", ansawer = "No evidence of compliance" };
            AuditQuestions question31 = new AuditQuestions { qustionText = "Water pumped from excavations to surface water drainage or onto ground", ansawer = "No evidence of compliance" };
            AuditQuestions question32 = new AuditQuestions { qustionText = "No evidence of fires or burnt rubbish", ansawer = "No evidence of compliance" };

            environmentalSite.auditQuestionsOthersLst.Add(question26);
            environmentalSite.auditQuestionsOthersLst.Add(question27);
            environmentalSite.auditQuestionsOthersLst.Add(question28);
            environmentalSite.auditQuestionsOthersLst.Add(question29);
            environmentalSite.auditQuestionsOthersLst.Add(question30);
            environmentalSite.auditQuestionsOthersLst.Add(question31);
            environmentalSite.auditQuestionsOthersLst.Add(question32);

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
