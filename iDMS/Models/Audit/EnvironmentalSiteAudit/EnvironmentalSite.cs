using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.EnvironmentalSiteAudit
{
    public class EnvironmentalSite
    {
        [Key]
        public int environmentalSiteId { get; set; }
        [DisplayName("Team Leader")]
        public string teamLeader { get; set; }
        [DisplayName("Team Operatives")]
        public string teamOperatives { get; set; }
        [DisplayName("Date/Time")]
        public DateTime dateTime { get; set; }
        [DisplayName("Vehicle Reg")]
        public string vehicleReg { get; set; }
        [DisplayName("Inspected by")]
        public string inspectedBy { get; set; }
        [DisplayName("Contract Number")]
        public string contractNumber { get; set; }
        [DisplayName("Location")]
        public string location { get; set; }
        [DisplayName("Audit Questions")]
        public List<AuditQuestions> auditQuestionsLst { get; set; }
        [DisplayName("Additional comments")]
        public string additionalComments { get; set; }
        //Environmental Actions and Closures (heading - not question)
        [DisplayName("AuditQuestions")]
        public int Number { get; set; }
        [DisplayName("Unsafe Act or Substandard Condition Observed")]
        public string unsafeActObserved { get; set; }
        [DisplayName("Immediate Action Taken")]
        public string immediateActionTaken { get; set; }
        [DisplayName("Signature")]
        public string signature { get; set; }
        [DisplayName("Date closed out")]
        public DateTime dateClousedOut { get; set; }
        [DisplayName("Score")]
        public int score { get; set; }
        [DisplayName("% score ")]
        public int percentageScore { get; set; }
    }
}
