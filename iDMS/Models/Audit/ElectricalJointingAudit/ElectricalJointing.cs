using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalJointingAudit
{
    public class ElectricalJointing
    {
        [Key]
        public int electricalJointingId { get; set; }
        public string teamLeader { get; set; }
        public string operative1 { get; set; }
        public string operative2 { get; set; }
        public string client { get; set; }
        public string auditor { get; set; }
        public string substationName { get; set; }
        public int substationNo { get; set; }
        public string activity { get; set; }
        public DateTime dateOfAudit { get; set; }
        public string developmentSite { get; set; }
        public string siteAddress { get; set; }
        //Audit Questions 
        public List<AuditQuestions> auditQuestionsLst { get; set; }
        public string nonConformance { get; set; }

        public string LocationOfWork { get; set; }
        public string owner { get; set; }
        public string target { get; set; }
        public string closed { get; set; }
        public DateTime date { get; set; }
        public string signature { get; set; }
        public string overallCommentsAndAssesment { get; set; }



        ////Audit Questions //Documents  
        //public List<AuditQuestions> auditQuestionsDocumentsLst { get; set; }
        ////Audit Questions //Cable Jointing Work   
        //public List<AuditQuestions> auditQuestionsCableJointingLst { get; set; }
        //public string specify { get; set; }
        ////all ‘Specify’ 

        ////Audit Questions //Cable Jointing Work   
        //public List<AuditQuestions> auditQuestionsTestingLst { get; set; }
        ////Audit Questions //Cable Jointing Work  
        //public List<AuditQuestions> auditQuestionsWorkPlaceLst { get; set; }
        ////Audit Questions //Equipment Positioning
        //public List<AuditQuestions> auditQuestionsEquipmentPositioningLst { get; set; }
        ////Audit Questions //o	Work Practices  
        //public List<AuditQuestions> auditQuestionsWorkPracticesLst { get; set; }



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
