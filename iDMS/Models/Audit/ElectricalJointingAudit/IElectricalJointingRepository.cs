using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models.Audit.ElectricalJointingAudit
{
    public interface IElectricalJointingRepository
    {
        ElectricalJointing Add(ElectricalJointing electricalJointing);
    }
}
