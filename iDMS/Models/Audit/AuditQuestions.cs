using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit
{
    public class AuditQuestions
    {
        [Key]
        public int questionId { get; set; }
        public string qustionText { get; set; }
        public string ansawer { get; set; }
        public string comments { get; set; }
        //for ElectricalDistributionAudit Questions Tools / Equipment 
        public DateTime equipmentTestingDate { get; set; }

        public string specify { get; set; }

        public string condition { get; set; }

        public DateTime expiryDate { get; set; }
        public string cardNumber { get; set; }


        public DateTime startDate { get; set; }
        public DateTime finishDate { get; set; }
    }
}
