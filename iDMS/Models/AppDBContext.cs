using iDMS.Models.Audit.ElectricalCableCivilAudit;
using iDMS.Models.Audit.ElectricalCableTechnical;
using iDMS.Models.Audit.ElectricalDistributionAudit;
using iDMS.Models.Audit.ElectricalJointingAudit;
using iDMS.Models.Audit.EnvironmentalSiteAudit;
using iDMS.Models.Audit.GasTechnicalAudit;
using iDMS.Models.Audit.HealthSafetyAudit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<HealthSafety> HealthSafetyAudit { get; set; }
        public DbSet<EnvironmentalSite> EnvironmentalSiteAudit { get; set; }
        public DbSet<ElectricalCableCivil> ElectricalCableCivilAudit { get; set; }
        public DbSet<ElectricalDistribution> ElectricalDistributionAudit { get; set; }
        public DbSet<ElectricalJointing> ElectricalJointingAudit { get; set; }
        public DbSet<ElectricalCableTechnical> ElectricalCableTechnicalAudit { get; set; }
        public DbSet<GasTechnical> GasTechnicalAudit { get; set; }
    }
}
