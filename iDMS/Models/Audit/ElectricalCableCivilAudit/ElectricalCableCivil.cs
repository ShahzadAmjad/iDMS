using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalCableCivilAudit
{
    public class ElectricalCableCivil
    {
        [Key]
        public int electricalCableCivilId { get; set; }
        [DisplayName("Contract Number")]
        public string contractNumber { get; set; }
        [DisplayName("Team Leader")]
        public string teamLeader { get; set; }
        [DisplayName("Operative 1")]
        public string operative1  { get; set; }
        [DisplayName("Operative 2")]
        public string operative2 { get; set; }
        [DisplayName("Client")]
        public string client { get; set; }
        [DisplayName("Auditor")]
        public string auditor { get; set; }
        [DisplayName("Job Ref No")]
        public int jobRefNo { get; set; }
        [DisplayName("Type of Work")]
        public string typeOfWork { get; set; }
        [DisplayName("Date of Audit")]
        public DateTime dateOfAudit { get; set; }
        [DisplayName("Development Site")]
        public string developmentSite { get; set; }
        [DisplayName("Site Address")]
        public string siteAddress { get; set; }
        [DisplayName("Date/time")]
        public DateTime dateTime { get; set; }

        //set A  Excavations 
        [DisplayName("Audit Questions")]
        public List<AuditQuestions> auditQuestionsLst { get; set; }
        //public List<AuditQuestions> auditQuestionsExcavationsLst { get; set; }

        [DisplayName("Depth of excavation dependent on voltage (mm)")]
        public string depthOfExcavation { get; set; }
        [DisplayName("What type of ducting is being used? ")]
        public string TypeOfDucting { get; set; }
        //[DisplayName("Audit Questions")]

        //set B  – Cable Installation  
        //public List<AuditQuestions> auditQuestionsCableInstallationLst { get; set; }



        [DisplayName("Cable type and size")]
        public string cableTypeAndSize { get; set; }
        [DisplayName("Cable length (m)")]
        public string cableLength { get; set; }
        [DisplayName("Type of bedding material")]
        public string typeOfBeddingMaterial { get; set; }
        [DisplayName("Depth of bedding material (75mm requirement)")]
        public string depthOfBeddingMaterial { get; set; }
        [DisplayName("Notes and observations")]
        //Main part
        public string notesAndObservations { get; set; }

        //•	Multiple lines can be added here, each one with following fields:
        [DisplayName("Non-conformance")]
        public string nonConformance  { get; set; }
        [DisplayName("Owner")]   
        public string owner { get; set; }        
        [DisplayName("Target date ")]
        public DateTime targetDate { get; set; }
        [DisplayName("Closed (details)")]
        public string closed { get; set; }
        [DisplayName("Date (data)")]
        public DateTime date { get; set; }
        [DisplayName("Signature")]
        public string signature { get; set; }
        [DisplayName("Overall comments and assessment")]
        public string overallCommentsAndAssesment { get; set; }

    }
}
