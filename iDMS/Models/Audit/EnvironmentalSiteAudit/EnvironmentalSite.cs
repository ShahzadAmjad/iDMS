using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.EnvironmentalSiteAudit
{
    public class EnvironmentalSite
    {
        [Key]
        public int environmentalSiteId { get; set; }
        public string teamLeader { get; set; }
        public string teamOperatives { get; set; }
        public DateTime dateTime { get; set; }

        public string vehicleReg { get; set; }
        public string inspectedBy { get; set; }
        public string contractNumber { get; set; }
        public string location { get; set; }
        //public string LocationOfWork { get; set; }
        //public string LocationOfWork { get; set; }
        public List<AuditQuestions> auditQuestionsVehiclesLst { get; set; }
        public List<AuditQuestions> auditQuestionsPlantLst { get; set; }
        public List<AuditQuestions> auditQuestionsHouseKeeepingLst { get; set; }
        public List<AuditQuestions> auditQuestionsCOSHHLst { get; set; }
        public List<AuditQuestions> auditQuestionsSpoilLst { get; set; }
        public List<AuditQuestions> auditQuestionsOthersLst { get; set; }
        public string additionalComments { get; set; }

        //Environmental Actions and Closures (heading - not question)
        public int number { get; set; }
        public string unsafeActObserved { get; set; }
        public string immediateActionTaken { get; set; }
        public string signature { get; set; }
        public DateTime dateClousedOut { get; set; }
        public int score { get; set; }
        public int percentageScore { get; set; }


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
