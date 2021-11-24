using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.GasTechnicalAudit
{
    public class SQLGasTechnicalRepository : IGasTechnicalRepository
    {
        private readonly AppDbContext Context;
        public SQLGasTechnicalRepository(AppDbContext context)
        {
            Context = context;
        }
        public GasTechnical Add(GasTechnical gasTechnical)
        {
            Context.GasTechnicalAudit.Add(gasTechnical);
            Context.SaveChanges();
            return gasTechnical;
        }
    }
}
