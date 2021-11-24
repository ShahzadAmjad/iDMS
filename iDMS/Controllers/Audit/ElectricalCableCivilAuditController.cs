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
        private IElectricalCableCivilRepository _electricalCableCivilRepository;
        public ElectricalCableCivilAuditController(IElectricalCableCivilRepository electricalCableCivilRepository)
        {
            _electricalCableCivilRepository = electricalCableCivilRepository;
        }
        public IActionResult Index()
        {
            return View("~/Views/Audit/ElectricalCableCivilAudit/ElectricalCableCivil.cshtml");
        }
        [HttpGet]
        public ViewResult ElectricalCableCivilAudit()
        {
            ElectricalCableCivil electricalCableCivil = new ElectricalCableCivil();
            electricalCableCivil.auditQuestionsLst = new List<AuditQuestions>() { };
            //Set A
            AuditQuestions question1 = new AuditQuestions { qustionText = "Surface being excavated (footway, carriageway, arable, etc.)?", ansawer = "" };
            AuditQuestions question2 = new AuditQuestions { qustionText = "Is the excavation the required depth for the installation of the cable and surroundings?", ansawer = "" };
            AuditQuestions question3 = new AuditQuestions { qustionText = "Is the excavation in the correct position according to the information from the client?", ansawer = "" };
            AuditQuestions question4 = new AuditQuestions { qustionText = "Does the excavation have the correct radii on the bends that is correct for cable installation?", ansawer = "" };
            AuditQuestions question5 = new AuditQuestions { qustionText = "Is the excavation free from sharp objects that can damage the cable when installed?", ansawer = "" };
            AuditQuestions question6 = new AuditQuestions { qustionText = "Is the excavation wide enough to allow the correct spacing between cables if more than 1 cable is installed?", ansawer = "" };
            AuditQuestions question7 = new AuditQuestions { qustionText = "Are joint bays the correct size to allow jointing to be carried out safely?", ansawer = "" };
            AuditQuestions question8 = new AuditQuestions { qustionText = "If ducting being installed, does it comply to the correct specification?", ansawer = "" };
            AuditQuestions question9 = new AuditQuestions { qustionText = "Is the ducting the correct size and type?", ansawer = "" };
            AuditQuestions question10 = new AuditQuestions { qustionText = "Are the ducts butted together properly to ensure the cable does not snag?", ansawer = "" };
            AuditQuestions question11 = new AuditQuestions { qustionText = "Has trenchless excavation taken place?", ansawer = "" };
            AuditQuestions question12 = new AuditQuestions { qustionText = "Is the cable being laid direct without ducting?", ansawer = "" };


            //Set B – Cable Installation (heading - not question)
            AuditQuestions question13 = new AuditQuestions { qustionText = "Is a bedding material used before cable installation (this is compulsory for 33kv and above and optional for other cables is there is a risk of damage to the cable during installation)?", ansawer = "" };
            AuditQuestions question14 = new AuditQuestions { qustionText = "Is the bedding material compacted to 75mm? ", ansawer = "" };
            AuditQuestions question15 = new AuditQuestions { qustionText = "Is a winch being used for the cable installation?", ansawer = "" };
            AuditQuestions question16 = new AuditQuestions { qustionText = "Does it have a trained operator?", ansawer = "" };
            AuditQuestions question17 = new AuditQuestions { qustionText = "Does the winch have a dynamometer to measure the pulling tension?", ansawer = "" };
            AuditQuestions question18 = new AuditQuestions { qustionText = "Is the dynamometer adjustable to ensure correct pulling tension?", ansawer = "" };
            AuditQuestions question19 = new AuditQuestions { qustionText = "Is there a calibration certificate available for the dynamometer?", ansawer = "" };
            AuditQuestions question20 = new AuditQuestions { qustionText = "Does the winch have a safety cutout to prevent over pulling of the cable?", ansawer = "" };
            AuditQuestions question21 = new AuditQuestions { qustionText = "Are the maximum cable pulling tensions available on site & have they been used as a reference?", ansawer = "" };
            AuditQuestions question22 = new AuditQuestions { qustionText = "Is the cable drum securely supported and can it turn freely?", ansawer = "" };
            AuditQuestions question23 = new AuditQuestions { qustionText = "Is there a cable pulling manual available on site and is it being used?", ansawer = "" };
            AuditQuestions question24 = new AuditQuestions { qustionText = "Are rollers being used along the route of the cable pull?", ansawer = "" };
            AuditQuestions question25 = new AuditQuestions { qustionText = "Are the rollers mechanically sound and rotate freely so as not to snag on the cable?", ansawer = "" };
            AuditQuestions question26 = new AuditQuestions { qustionText = "Is there a roller present at the start of the pull to guide the cable into the trench?", ansawer = "" };
            AuditQuestions question27 = new AuditQuestions { qustionText = "Is the nose of the cable protected with a heat shrink cap?", ansawer = "" };
            AuditQuestions question28 = new AuditQuestions { qustionText = "Is the cable stocking free of defects?", ansawer = "" };
            AuditQuestions question29 = new AuditQuestions { qustionText = "Is the stocking tied securely to the end of the cable?", ansawer = "" };
            AuditQuestions question30 = new AuditQuestions { qustionText = "Is a swivel being used between the stocking and winch bond and nothing protruding from the swivel that may catch and deform a duct?", ansawer = "" };
            AuditQuestions question31 = new AuditQuestions { qustionText = "Are there at least 2 2-way radios on site to aid communication throughout the Pull? ", ansawer = "" };
            AuditQuestions question32 = new AuditQuestions { qustionText = "Is cable lubricant available on site to aid pulling through ducts and is it being used?", ansawer = "" };
            AuditQuestions question33 = new AuditQuestions { qustionText = "Has the cable been positioned in the centre of the trench to enable even blinding?", ansawer = "" };
            AuditQuestions question34 = new AuditQuestions { qustionText = "Has the cable been damaged in any way along the route and has this been checked before blinding the cable?", ansawer = "" };
            AuditQuestions question35 = new AuditQuestions { qustionText = "What blinding material is available to use (20kv and below, imported sand can be used if excavated material is not suitable)?", ansawer = "" };
            AuditQuestions question36 = new AuditQuestions { qustionText = "Is the blinding compacted to a depth of 100mm above the cable/joint?", ansawer = "" };
            AuditQuestions question37 = new AuditQuestions { qustionText = "Is the marker tape laid directly over the cable, not just in the trench? ", ansawer = "" };
            AuditQuestions question38 = new AuditQuestions { qustionText = "Stokboards are to be used on 33,66,132kv?", ansawer = "" };
            AuditQuestions question39 = new AuditQuestions { qustionText = "If stokboards are used, have they been pinned together?", ansawer = "" };


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
            electricalCableCivil.auditQuestionsLst.Add(question30);
            electricalCableCivil.auditQuestionsLst.Add(question31);
            electricalCableCivil.auditQuestionsLst.Add(question32);
            electricalCableCivil.auditQuestionsLst.Add(question33);
            electricalCableCivil.auditQuestionsLst.Add(question34);
            electricalCableCivil.auditQuestionsLst.Add(question35);
            electricalCableCivil.auditQuestionsLst.Add(question36);
            electricalCableCivil.auditQuestionsLst.Add(question37);
            electricalCableCivil.auditQuestionsLst.Add(question38);
            electricalCableCivil.auditQuestionsLst.Add(question39);



            return View("~/Views/Audit/ElectricalCableCivilAudit/ElectricalCableCivil.cshtml", electricalCableCivil);
        }

        [HttpPost]
        public IActionResult ElectricalCableCivilAudit(ElectricalCableCivil electricalCableCivil)
        {
            _electricalCableCivilRepository.Add(electricalCableCivil);


            return View("~/Views/Home/Home.cshtml");
        }

    }
}
