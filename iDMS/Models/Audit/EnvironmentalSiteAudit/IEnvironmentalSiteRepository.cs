using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.EnvironmentalSiteAudit
{
    public interface IEnvironmentalSiteRepository
    {
        EnvironmentalSite Add(EnvironmentalSite environmentalSiteAudit);
    }
}
