using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalJointingAudit
{
    public class SQLElectricalJointingRepository : IElectricalJointingRepository
    {
        private readonly AppDbContext Context;
        public SQLElectricalJointingRepository(AppDbContext context)
        {
            Context = context;
        }
        public ElectricalJointing Add(ElectricalJointing electricalJointing)
        {
            Context.ElectricalJointingAudit.Add(electricalJointing);
            Context.SaveChanges();
            return electricalJointing;
        }
    }
}
