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
        public int electricalCableCivilId { get; set; }
        public string locationOfWork { get; set; }
        public string typeOfWork { get; set; }
        public string teamLeader { get; set; }
        public string contractor { get; set; }
        public int projectNo { get; set; }
        public DateTime dateTime { get; set; }
        public List<AuditQuestions> auditQuestionsLst { get; set; }
        public string defectFound { get; set; }
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
