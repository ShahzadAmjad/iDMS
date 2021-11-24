using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalCableTechnical
{
    public class SQLElectricalCableTechnicalRepository : IElectricalCableTechnicalRepository
    {
        private readonly AppDbContext Context;
        public SQLElectricalCableTechnicalRepository(AppDbContext context)
        {
            Context = context;
        }
        public ElectricalCableTechnical Add(ElectricalCableTechnical electricalCableTechnical)
        {
            Context.ElectricalCableTechnicalAudit.Add(electricalCableTechnical);
            Context.SaveChanges();
            return electricalCableTechnical;
        }
    }
}
