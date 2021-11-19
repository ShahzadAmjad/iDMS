using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iDMS.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectricalCableCivilAudit",
                columns: table => new
                {
                    electricalCableCivilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contractNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teamLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    operative1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    operative2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    auditor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jobRefNo = table.Column<int>(type: "int", nullable: false),
                    typeOfWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateOfAudit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    developmentSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    siteAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    depthOfExcavation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfDucting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cableTypeAndSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cableLength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeOfBeddingMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    depthOfBeddingMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notesAndObservations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nonConformance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    targetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    closed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    signature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    overallCommentsAndAssesment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalCableCivilAudit", x => x.electricalCableCivilId);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalCableTechnicalAudit",
                columns: table => new
                {
                    electricalCableTechnicalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    auditor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subContractor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projectmanager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teamLeaderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projectNo = table.Column<int>(type: "int", nullable: false),
                    developer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contractSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matesName = table.Column<int>(type: "int", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    typeOfAudit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthlyAuditResults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sentTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remedialActionTaken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    replyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalCableTechnicalAudit", x => x.electricalCableTechnicalId);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalDistributionAudit",
                columns: table => new
                {
                    electricalDistributionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contractNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teamLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    operative1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    operative2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    auditor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    substationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    substationNo = table.Column<int>(type: "int", nullable: false),
                    activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateOfAudit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    developmentSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    siteAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    testingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nonConformance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    targetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    closed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    signature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    overallCommentsAndAssesment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalDistributionAudit", x => x.electricalDistributionId);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalJointingAudit",
                columns: table => new
                {
                    electricalJointingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teamLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    operative1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    operative2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    auditor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    substationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    substationNo = table.Column<int>(type: "int", nullable: false),
                    activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateOfAudit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    developmentSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    siteAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nonConformance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationOfWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    closed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    signature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    overallCommentsAndAssesment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalJointingAudit", x => x.electricalJointingId);
                });

            migrationBuilder.CreateTable(
                name: "EnvironmentalSiteAudit",
                columns: table => new
                {
                    environmentalSiteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teamLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teamOperatives = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vehicleReg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspectedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contractNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    additionalComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    unsafeActObserved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    immediateActionTaken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    signature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateClousedOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    score = table.Column<int>(type: "int", nullable: false),
                    percentageScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentalSiteAudit", x => x.environmentalSiteId);
                });

            migrationBuilder.CreateTable(
                name: "GasTechnicalAudit",
                columns: table => new
                {
                    gasTechnicalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projectNo = table.Column<int>(type: "int", nullable: false),
                    contractor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    developer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projectManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contractSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teamLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Auditor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    typeOfAudit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthlyAuditResults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sentTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remedialActionTaken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    replyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GasTechnicalAudit", x => x.gasTechnicalId);
                });

            migrationBuilder.CreateTable(
                name: "HealthSafetyAudit",
                columns: table => new
                {
                    HealthSafetyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locationOfWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeOfWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teamLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contractor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projectNo = table.Column<int>(type: "int", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    defectFound = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remedialActionTaken = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthSafetyAudit", x => x.HealthSafetyId);
                });

            migrationBuilder.CreateTable(
                name: "AuditQuestions",
                columns: table => new
                {
                    questionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qustionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ansawer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equipmentTestingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HealthSafetyId = table.Column<int>(type: "int", nullable: true),
                    electricalCableCivilId = table.Column<int>(type: "int", nullable: true),
                    electricalCableTechnicalId = table.Column<int>(type: "int", nullable: true),
                    electricalDistributionId = table.Column<int>(type: "int", nullable: true),
                    electricalJointingId = table.Column<int>(type: "int", nullable: true),
                    environmentalSiteId = table.Column<int>(type: "int", nullable: true),
                    gasTechnicalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditQuestions", x => x.questionId);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_ElectricalCableCivilAudit_electricalCableCivilId",
                        column: x => x.electricalCableCivilId,
                        principalTable: "ElectricalCableCivilAudit",
                        principalColumn: "electricalCableCivilId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_ElectricalCableTechnicalAudit_electricalCableTechnicalId",
                        column: x => x.electricalCableTechnicalId,
                        principalTable: "ElectricalCableTechnicalAudit",
                        principalColumn: "electricalCableTechnicalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_ElectricalDistributionAudit_electricalDistributionId",
                        column: x => x.electricalDistributionId,
                        principalTable: "ElectricalDistributionAudit",
                        principalColumn: "electricalDistributionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_ElectricalJointingAudit_electricalJointingId",
                        column: x => x.electricalJointingId,
                        principalTable: "ElectricalJointingAudit",
                        principalColumn: "electricalJointingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId",
                        column: x => x.environmentalSiteId,
                        principalTable: "EnvironmentalSiteAudit",
                        principalColumn: "environmentalSiteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_GasTechnicalAudit_gasTechnicalId",
                        column: x => x.gasTechnicalId,
                        principalTable: "GasTechnicalAudit",
                        principalColumn: "gasTechnicalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_HealthSafetyAudit_HealthSafetyId",
                        column: x => x.HealthSafetyId,
                        principalTable: "HealthSafetyAudit",
                        principalColumn: "HealthSafetyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_electricalCableCivilId",
                table: "AuditQuestions",
                column: "electricalCableCivilId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_electricalCableTechnicalId",
                table: "AuditQuestions",
                column: "electricalCableTechnicalId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_electricalDistributionId",
                table: "AuditQuestions",
                column: "electricalDistributionId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_electricalJointingId",
                table: "AuditQuestions",
                column: "electricalJointingId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_environmentalSiteId",
                table: "AuditQuestions",
                column: "environmentalSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_gasTechnicalId",
                table: "AuditQuestions",
                column: "gasTechnicalId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_HealthSafetyId",
                table: "AuditQuestions",
                column: "HealthSafetyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditQuestions");

            migrationBuilder.DropTable(
                name: "ElectricalCableCivilAudit");

            migrationBuilder.DropTable(
                name: "ElectricalCableTechnicalAudit");

            migrationBuilder.DropTable(
                name: "ElectricalDistributionAudit");

            migrationBuilder.DropTable(
                name: "ElectricalJointingAudit");

            migrationBuilder.DropTable(
                name: "EnvironmentalSiteAudit");

            migrationBuilder.DropTable(
                name: "GasTechnicalAudit");

            migrationBuilder.DropTable(
                name: "HealthSafetyAudit");
        }
    }
}
