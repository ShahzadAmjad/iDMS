using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.GasTechnicalAudit
{
    public class GasTechnical
    {
        [Key]
        public int gasTechnicalId { get; set; }
        public string projectName { get; set; }
        public int projectNo { get; set; }
        public string contractor { get; set; }
        public string developer { get; set; }
        public string projectManager { get; set; }
        public string contractSupervisor { get; set; }
        public string teamLeader { get; set; }
        public string matesName { get; set; }
        public string Auditor { get; set; }
        public DateTime dateTime { get; set; }
        public string typeOfAudit { get; set; }
        public string Activity { get; set; }

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
