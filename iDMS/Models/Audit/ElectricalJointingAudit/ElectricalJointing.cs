using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalJointingAudit
{
    public class ElectricalJointing
    {
        [Key]
        public int electricalJointingId { get; set; }
        [DisplayName("Team Leader")]
        public string teamLeader { get; set; }
        [DisplayName("Operative 1")]
        public string operative1 { get; set; }
        [DisplayName("Operative 2")]
        public string operative2 { get; set; }
        [DisplayName("Client")]
        public string client { get; set; }
        [DisplayName("Auditor")]
        public string auditor { get; set; }
        [DisplayName("Substation Name")]
        public string substationName { get; set; }
        [DisplayName("Substation No")]
        public int substationNo { get; set; }
        [DisplayName("Activity")]
        public string activity { get; set; }
        [DisplayName("Date of Audit")]
        public DateTime dateOfAudit { get; set; }
        [DisplayName("Development Site")]
        public string developmentSite { get; set; }
        [DisplayName("Site Address")]
        public string siteAddress { get; set; }
        [DisplayName("Audit Address")]
        //Audit Questions 
        public List<AuditQuestions> auditQuestionsLst { get; set; }
        [DisplayName("Non-conformance ")]
        public string nonConformance { get; set; }
        [DisplayName("Owner ")]
        public string owner { get; set; }

        [DisplayName("Target Date")]
        public DateTime targetDate { get; set; }
        [DisplayName("Closed")]
        public string closed { get; set; }
        [DisplayName("Date")]
        public DateTime date { get; set; }
        [DisplayName("Signature")]
        public string signature { get; set; }
        [DisplayName("Overall comments and assessment")]
        public string overallCommentsAndAssesment { get; set; }
    }
}
