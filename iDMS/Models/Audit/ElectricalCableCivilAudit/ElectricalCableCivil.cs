using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalCableCivilAudit
{
    public class ElectricalCableCivil
    {
        [Key]
        public int electricalCableCivilId { get; set; }
        public string contractNumber { get; set; }
        public string teamLeader { get; set; }
        public string operative1  { get; set; }
        public string operative2 { get; set; }
        public string client { get; set; }

        public int jobRefNo { get; set; }
        public string typeOfWork { get; set; }
        public DateTime dateOfAudit { get; set; }

        public string developmentSite { get; set; }
        public string siteAddress { get; set; }
        public DateTime dateTime { get; set; }

        //set A  Excavations 
        public List<AuditQuestions> auditQuestionsExcavationsLst { get; set; }
        public string depthOfExcavation { get; set; }
        public string TypeOfDucting { get; set; }

        //set B  – Cable Installation  
        public List<AuditQuestions> auditQuestionsCableInstallationLst { get; set; }
        public string cableTypeAndSize { get; set; }
        public string cableLength { get; set; }
        public string typeOfBeddingMaterial { get; set; }
        public string depthOfBeddingMaterial { get; set; }

        //Main part


        public string notesAndObservations { get; set; }
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
