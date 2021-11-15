using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalDistributionAudit
{
    public class ElectricalDistribution
    {
        [Key]
        public int electricalDistributionId { get; set; }
        public string contractNumber { get; set; }
        public string teamLeader { get; set; }
        public string operative1 { get; set; }
        public string operative2 { get; set; }
        public string client { get; set; }

        public string auditor { get; set; }
        public string substationName { get; set; }
        public int  substationNo { get; set; }
        public string activity { get; set; }

        public DateTime dateOfAudit { get; set; }
        public string developmentSite { get; set; }
        public string siteAddress { get; set; }

        //Audit Questions
        public List<AuditQuestions> auditQuestionsDocumentsLst { get; set; }
        public List<AuditQuestions> auditQuestionsSubstationWorkLst { get; set; }
        public List<AuditQuestions> auditQuestionsSubstationMaintenanceLst { get; set; }
        //Also include a testing date field
        //NOTE: These also include a ‘testing date’ field:
        public List<AuditQuestions> auditQuestionsToolsEquipmentLst { get; set; }
        public DateTime testingDate { get; set; }

        //small tools

        public List<AuditQuestions> auditQuestionsSmallToolsLst { get; set; }

        public List<AuditQuestions> auditQuestionsPPELst { get; set; }
        
        public string nonConformance { get; set; }
        public string LocationOfWork { get; set; }
        public string owner { get; set; }
        public string target { get; set; }
        public string closed { get; set; }
        public DateTime date { get; set; }
        public string signature { get; set; }
        public string overallCommentsAndAssesment { get; set; }




        //public string defectFound { get; set; }
        //public string remedialActionTaken { get; set; }

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
