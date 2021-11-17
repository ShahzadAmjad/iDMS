using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.EnvironmentalSiteAudit
{
    public class SQLEnvironmentalSiteRepository : IEnvironmentalSiteRepository
    {
        private readonly AppDbContext Context;
        public SQLEnvironmentalSiteRepository(AppDbContext context)
        {
            Context = context;
        }
        public EnvironmentalSite Add(EnvironmentalSite environmentalSiteAudit)
        {
            Context.EnvironmentalSiteAudit.Add(environmentalSiteAudit);
            Context.SaveChanges();
            return environmentalSiteAudit;
        }
    }
}
