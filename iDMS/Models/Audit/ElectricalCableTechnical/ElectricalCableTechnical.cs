using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalCableTechnical
{
    public class ElectricalCableTechnical
    {
        [Key]
        public int electricalCableTechnicalId { get; set; }
        [DisplayName("Project title ")]
        public string projectTitle  { get; set; }
        [DisplayName("Auditor ")]
        public string auditor { get; set; }
        [DisplayName("Sub-contractor")]
        public string subContractor { get; set; }
        [DisplayName("Project Manager")]
        public string projectmanager { get; set; }
        [DisplayName("Team Leader Name ")]
        public string teamLeaderName { get; set; }
        [DisplayName("Project No.")]
        public int projectNo { get; set; }
        [DisplayName("Developer ")]
        public string developer { get; set; }
        [DisplayName("Contract Supervisor ")]
        public string contractSupervisor { get; set; }
        [DisplayName("Mate’s Name ")]
        public int matesName { get; set; }
        [DisplayName("Date/time")]
        public DateTime dateTime { get; set; }
        //radio button ‘Ad-hoc/Regular’, ‘Quarterly’
        [DisplayName("Type of Audit")]
        public string typeOfAudit { get; set; }
        [DisplayName("Audit Questions")]
        public List<AuditQuestions> auditQuestionsLst { get; set; }
        [DisplayName("Monthly Audit Results")]
        public string monthlyAuditResults { get; set; }
        //•	Corrective Action Report Details (multiple)
        [DisplayName("Date")]
        public DateTime date { get; set; }
        [DisplayName("Sent to ")]
        public string sentTo { get; set; }
        [DisplayName("Remedial Action Taken ")]
        public string remedialActionTaken { get; set; }
        [DisplayName("Reply Date ")]
        public DateTime replyDate { get; set; }

        
       
    }
}
