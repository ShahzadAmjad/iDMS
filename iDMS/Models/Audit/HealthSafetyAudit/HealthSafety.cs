using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.HealthSafetyAudit
{
    public class HealthSafety
    {
        [Key]
        public int HealthSafetyId { get; set; }
        [DisplayName("Location of work")]
        public string locationOfWork { get; set; }
        [DisplayName("Type of work")]
        public string typeOfWork { get; set; }
        [DisplayName("Team Leader")]
        public string teamLeader { get; set; }
        [DisplayName("Contractor")]
        public string contractor { get; set; }
        [DisplayName("Project No")]
        public int projectNo { get; set; }
        [DisplayName("Date/Time")]
        public DateTime dateTime { get; set; }
        [DisplayName("Audit Questions")]
        public List<AuditQuestions> auditQuestionsLst { get; set; }
        [DisplayName("Defect Found")]
        public string defectFound { get; set; }
        [DisplayName("Remedial action taken")]
        public string remedialActionTaken { get; set; }

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
