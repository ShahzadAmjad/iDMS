using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.GasTechnicalAudit
{
    public class GasTechnical
    {
        [Key]
        public int gasTechnicalId { get; set; }
        [DisplayName("Project title")]
        public string projectTitle { get; set; }
        [DisplayName("Project No. ")]
        public int projectNo { get; set; }
        [DisplayName("Contractor ")]
        public string contractor { get; set; }
        [DisplayName("Developer ")]
        public string developer { get; set; }
        [DisplayName("Project Manager ")]
        public string projectManager { get; set; }
        [DisplayName("Contract Supervisor ")]
        public string contractSupervisor { get; set; }
        [DisplayName("Team Leader")]
        public string teamLeader { get; set; }
        [DisplayName("Mate’s Name ")]
        public string matesName { get; set; }
        [DisplayName("Auditor ")]
        public string Auditor { get; set; }
        [DisplayName("Date/time ")]
        public DateTime dateTime { get; set; }
        [DisplayName("Type of Audit")]
        //radio buttons ‘Ad-hoc/Regular’, ‘Quarterly’)
        public string typeOfAudit { get; set; }
        //radio buttons ‘Mainlaying / Servicelaying / Connection’)
        [DisplayName("Activity ")]
        public string Activity { get; set; }
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
