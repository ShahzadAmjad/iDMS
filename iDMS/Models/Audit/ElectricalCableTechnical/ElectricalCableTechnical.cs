using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalCableTechnical
{
    public class ElectricalCableTechnical
    {
        [Key]
        public int electricalCableTechnicalId { get; set; }
        public string projectTitle  { get; set; }
        public string auditor { get; set; }
        public string subContractor { get; set; }
        public string projectmanager { get; set; }
        public string teamLeaderName { get; set; }
        public int projectNo { get; set; }
        public string developer { get; set; }
        public string contractSupervisor { get; set; }
        public int matesName { get; set; }
        public DateTime dateTime { get; set; }

        public string typeOfAudit { get; set; }
        

        public List<AuditQuestions> auditQuestionsLst { get; set; }

        public string monthlyAuditResults { get; set; }
        //•	Corrective Action Report Details (multiple)
        public DateTime date { get; set; }

        public string sentTo { get; set; }
        public string remedialActionTaken { get; set; }
        public DateTime replyDate { get; set; }


        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
    }
}
