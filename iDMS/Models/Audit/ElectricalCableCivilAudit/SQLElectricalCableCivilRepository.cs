using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalCableCivilAudit
{
    public class SQLElectricalCableCivilRepository : IElectricalCableCivilRepository
    {
        private readonly AppDbContext Context;
        public SQLElectricalCableCivilRepository(AppDbContext context)
        {
            Context = context;
        }
        public ElectricalCableCivil Add(ElectricalCableCivil electricalCableCivil)
        {
            Context.ElectricalCableCivilAudit.Add(electricalCableCivil);
            Context.SaveChanges();
            return electricalCableCivil;
        }
    }
}
