using iDMS.Models.Audit.HealthSafetyAudit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.HealthSafetyAudit
{
    public class SQLHealthSafetyRepository : IHealthSafetyRepository
    {
        private readonly AppDbContext Context;
        public SQLHealthSafetyRepository(AppDbContext context)
        {
            Context = context;
        }
        public HealthSafety Add(HealthSafety healthSafetyAudit)
        {
            Context.HealthSafetyAudit.Add(healthSafetyAudit);
            Context.SaveChanges();
            return healthSafetyAudit;
        }
    }
}
