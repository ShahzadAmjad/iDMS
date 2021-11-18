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
            //Set A
            AuditQuestions question1 = new AuditQuestions { qustionText = "Surface being excavated (footway, carriageway, arable, etc.)?", ansawer = "Yes" };
            AuditQuestions question2 = new AuditQuestions { qustionText = "Is the excavation the required depth for the installation of the cable and surroundings?", ansawer = "Yes" };
            AuditQuestions question3 = new AuditQuestions { qustionText = "Is the excavation in the correct position according to the information from the client?", ansawer = "Yes" };
            AuditQuestions question4 = new AuditQuestions { qustionText = "Does the excavation have the correct radii on the bends that is correct for cable installation?", ansawer = "Yes" };
            AuditQuestions question5 = new AuditQuestions { qustionText = "Is the excavation free from sharp objects that can damage the cable when installed?", ansawer = "Yes" };
            AuditQuestions question6 = new AuditQuestions { qustionText = "Is the excavation wide enough to allow the correct spacing between cables if more than 1 cable is installed?", ansawer = "Yes" };
            AuditQuestions question7 = new AuditQuestions { qustionText = "Are joint bays the correct size to allow jointing to be carried out safely?", ansawer = "Yes" };
            AuditQuestions question8 = new AuditQuestions { qustionText = "If ducting being installed, does it comply to the correct specification?", ansawer = "Yes" };
            AuditQuestions question9 = new AuditQuestions { qustionText = "Is the ducting the correct size and type?", ansawer = "Yes" };
            AuditQuestions question10 = new AuditQuestions { qustionText = "Are the ducts butted together properly to ensure the cable does not snag?", ansawer = "Yes" };
            AuditQuestions question11 = new AuditQuestions { qustionText = "Has trenchless excavation taken place?", ansawer = "Yes" };
            AuditQuestions question12 = new AuditQuestions { qustionText = "Is the cable being laid direct without ducting?", ansawer = "Yes" };


            //Set B – Cable Installation (heading - not question)
            AuditQuestions question13 = new AuditQuestions { qustionText = "Is a bedding material used before cable installation (this is compulsory for 33kv and above and optional for other cables is there is a risk of damage to the cable during installation)?", ansawer = "Yes" };
            AuditQuestions question14 = new AuditQuestions { qustionText = "Is the bedding material compacted to 75mm? ", ansawer = "Yes" };
            AuditQuestions question15 = new AuditQuestions { qustionText = "Is a winch being used for the cable installation?", ansawer = "Yes" };
            AuditQuestions question16 = new AuditQuestions { qustionText = "Does it have a trained operator?", ansawer = "Yes" };
            AuditQuestions question17 = new AuditQuestions { qustionText = "Does the winch have a dynamometer to measure the pulling tension?", ansawer = "Yes" };
            AuditQuestions question18 = new AuditQuestions { qustionText = "Is the dynamometer adjustable to ensure correct pulling tension?", ansawer = "Yes" };
            AuditQuestions question19 = new AuditQuestions { qustionText = "Is there a calibration certificate available for the dynamometer?", ansawer = "Yes" };
            AuditQuestions question20 = new AuditQuestions { qustionText = "Does the winch have a safety cutout to prevent over pulling of the cable?", ansawer = "Yes" };
            AuditQuestions question21 = new AuditQuestions { qustionText = "Are the maximum cable pulling tensions available on site & have they been used as a reference?", ansawer = "Yes" };
            AuditQuestions question22 = new AuditQuestions { qustionText = "Is the cable drum securely supported and can it turn freely?", ansawer = "Yes" };
            AuditQuestions question23 = new AuditQuestions { qustionText = "Is there a cable pulling manual available on site and is it being used?", ansawer = "Yes" };
            AuditQuestions question24 = new AuditQuestions { qustionText = "Are rollers being used along the route of the cable pull?", ansawer = "Yes" };
            AuditQuestions question25 = new AuditQuestions { qustionText = "Are the rollers mechanically sound and rotate freely so as not to snag on the cable?", ansawer = "Yes" };
            AuditQuestions question26 = new AuditQuestions { qustionText = "Is there a roller present at the start of the pull to guide the cable into the trench?", ansawer = "Yes" };
            AuditQuestions question27 = new AuditQuestions { qustionText = "Is the nose of the cable protected with a heat shrink cap?", ansawer = "Yes" };
            AuditQuestions question28 = new AuditQuestions { qustionText = "Is the cable stocking free of defects?", ansawer = "Yes" };
            AuditQuestions question29 = new AuditQuestions { qustionText = "Is the stocking tied securely to the end of the cable?", ansawer = "Yes" };
            AuditQuestions question30 = new AuditQuestions { qustionText = "Is a swivel being used between the stocking and winch bond and nothing protruding from the swivel that may catch and deform a duct?", ansawer = "Yes" };
            AuditQuestions question31 = new AuditQuestions { qustionText = "Are there at least 2 2-way radios on site to aid communication throughout the Pull? ", ansawer = "Yes" };
            AuditQuestions question32 = new AuditQuestions { qustionText = "Is cable lubricant available on site to aid pulling through ducts and is it being used?", ansawer = "Yes" };
            AuditQuestions question33 = new AuditQuestions { qustionText = "Has the cable been positioned in the centre of the trench to enable even blinding?", ansawer = "Yes" };
            AuditQuestions question34 = new AuditQuestions { qustionText = "Has the cable been damaged in any way along the route and has this been checked before blinding the cable?", ansawer = "Yes" };
            AuditQuestions question35 = new AuditQuestions { qustionText = "What blinding material is available to use (20kv and below, imported sand can be used if excavated material is not suitable)?", ansawer = "Yes" };
            AuditQuestions question36 = new AuditQuestions { qustionText = "Is the blinding compacted to a depth of 100mm above the cable/joint?", ansawer = "Yes" };
            AuditQuestions question37 = new AuditQuestions { qustionText = "Is the marker tape laid directly over the cable, not just in the trench? ", ansawer = "Yes" };
            AuditQuestions question38 = new AuditQuestions { qustionText = "Stokboards are to be used on 33,66,132kv?", ansawer = "Yes" };
            AuditQuestions question39 = new AuditQuestions { qustionText = "If stokboards are used, have they been pinned together?", ansawer = "Yes" };


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



    }
}
