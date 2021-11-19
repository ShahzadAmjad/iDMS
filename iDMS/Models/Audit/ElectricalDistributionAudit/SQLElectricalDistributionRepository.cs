using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalDistributionAudit
{
    public class SQLElectricalDistributionRepository : IElectricalDistributionRepository
    {
        private readonly AppDbContext Context;
        public SQLElectricalDistributionRepository(AppDbContext context)
        {
            Context = context;
        }
        public ElectricalDistribution Add(ElectricalDistribution electricalDistribution)
        {
            Context.ElectricalDistributionAudit.Add(electricalDistribution);
            Context.SaveChanges();
            return electricalDistribution;
        }
    }
}
