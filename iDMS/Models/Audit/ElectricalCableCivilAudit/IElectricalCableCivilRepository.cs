using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalCableCivilAudit
{
    public interface IElectricalCableCivilRepository
    {
        ElectricalCableCivil Add(ElectricalCableCivil electricalCableCivil);
    }
}
