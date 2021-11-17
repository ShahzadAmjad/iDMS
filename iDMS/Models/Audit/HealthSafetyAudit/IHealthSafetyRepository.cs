using iDMS.Models.Audit.HealthSafetyAudit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.HealthSafetyAudit
{
    public interface IHealthSafetyRepository
    {
        HealthSafety Add(HealthSafety healthSafetyAudit);
    }
}
