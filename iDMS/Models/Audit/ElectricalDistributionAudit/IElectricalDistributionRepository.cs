using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalDistributionAudit
{
    public interface IElectricalDistributionRepository
    {
        ElectricalDistribution Add(ElectricalDistribution electricalDistribution);
    }
}
