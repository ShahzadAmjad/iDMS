using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.GasTechnicalAudit
{
    public interface IGasTechnicalRepository
    {
        GasTechnical Add(GasTechnical gasTechnical);
    }
}
