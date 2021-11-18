using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iDMS.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId1",
                table: "AuditQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId2",
                table: "AuditQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId3",
                table: "AuditQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId4",
                table: "AuditQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId5",
                table: "AuditQuestions");

            migrationBuilder.RenameColumn(
                name: "environmentalSiteId5",
                table: "AuditQuestions",
                newName: "gasTechnicalId");

            migrationBuilder.RenameColumn(
                name: "environmentalSiteId4",
                table: "AuditQuestions",
                newName: "electricalJointingId");

            migrationBuilder.RenameColumn(
                name: "environmentalSiteId3",
                table: "AuditQuestions",
                newName: "electricalDistributionId");

            migrationBuilder.RenameColumn(
                name: "environmentalSiteId2",
                table: "AuditQuestions",
                newName: "electricalCableTechnicalId");

            migrationBuilder.RenameColumn(
                name: "environmentalSiteId1",
                table: "AuditQuestions",
                newName: "electricalCableCivilId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditQuestions_environmentalSiteId5",
                table: "AuditQuestions",
                newName: "IX_AuditQuestions_gasTechnicalId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditQuestions_environmentalSiteId4",
                table: "AuditQuestions",
                newName: "IX_AuditQuestions_electricalJointingId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditQuestions_environmentalSiteId3",
                table: "AuditQuestions",
                newName: "IX_AuditQuestions_electricalDistributionId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditQuestions_environmentalSiteId2",
                table: "AuditQuestions",
                newName: "IX_AuditQuestions_electricalCableTechnicalId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditQuestions_environmentalSiteId1",
                table: "AuditQuestions",
                newName: "IX_AuditQuestions_electricalCableCivilId");

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
                    targetDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.AddForeignKey(
                name: "FK_AuditQuestions_ElectricalCableCivilAudit_electricalCableCivilId",
                table: "AuditQuestions",
                column: "electricalCableCivilId",
                principalTable: "ElectricalCableCivilAudit",
                principalColumn: "electricalCableCivilId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditQuestions_ElectricalCableTechnicalAudit_electricalCableTechnicalId",
                table: "AuditQuestions",
                column: "electricalCableTechnicalId",
                principalTable: "ElectricalCableTechnicalAudit",
                principalColumn: "electricalCableTechnicalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditQuestions_ElectricalDistributionAudit_electricalDistributionId",
                table: "AuditQuestions",
                column: "electricalDistributionId",
                principalTable: "ElectricalDistributionAudit",
                principalColumn: "electricalDistributionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditQuestions_ElectricalJointingAudit_electricalJointingId",
                table: "AuditQuestions",
                column: "electricalJointingId",
                principalTable: "ElectricalJointingAudit",
                principalColumn: "electricalJointingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditQuestions_GasTechnicalAudit_gasTechnicalId",
                table: "AuditQuestions",
                column: "gasTechnicalId",
                principalTable: "GasTechnicalAudit",
                principalColumn: "gasTechnicalId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditQuestions_ElectricalCableCivilAudit_electricalCableCivilId",
                table: "AuditQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditQuestions_ElectricalCableTechnicalAudit_electricalCableTechnicalId",
                table: "AuditQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditQuestions_ElectricalDistributionAudit_electricalDistributionId",
                table: "AuditQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditQuestions_ElectricalJointingAudit_electricalJointingId",
                table: "AuditQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditQuestions_GasTechnicalAudit_gasTechnicalId",
                table: "AuditQuestions");

            migrationBuilder.DropTable(
                name: "ElectricalCableCivilAudit");

            migrationBuilder.DropTable(
                name: "ElectricalCableTechnicalAudit");

            migrationBuilder.DropTable(
                name: "ElectricalDistributionAudit");

            migrationBuilder.DropTable(
                name: "ElectricalJointingAudit");

            migrationBuilder.DropTable(
                name: "GasTechnicalAudit");

            migrationBuilder.RenameColumn(
                name: "gasTechnicalId",
                table: "AuditQuestions",
                newName: "environmentalSiteId5");

            migrationBuilder.RenameColumn(
                name: "electricalJointingId",
                table: "AuditQuestions",
                newName: "environmentalSiteId4");

            migrationBuilder.RenameColumn(
                name: "electricalDistributionId",
                table: "AuditQuestions",
                newName: "environmentalSiteId3");

            migrationBuilder.RenameColumn(
                name: "electricalCableTechnicalId",
                table: "AuditQuestions",
                newName: "environmentalSiteId2");

            migrationBuilder.RenameColumn(
                name: "electricalCableCivilId",
                table: "AuditQuestions",
                newName: "environmentalSiteId1");

            migrationBuilder.RenameIndex(
                name: "IX_AuditQuestions_gasTechnicalId",
                table: "AuditQuestions",
                newName: "IX_AuditQuestions_environmentalSiteId5");

            migrationBuilder.RenameIndex(
                name: "IX_AuditQuestions_electricalJointingId",
                table: "AuditQuestions",
                newName: "IX_AuditQuestions_environmentalSiteId4");

            migrationBuilder.RenameIndex(
                name: "IX_AuditQuestions_electricalDistributionId",
                table: "AuditQuestions",
                newName: "IX_AuditQuestions_environmentalSiteId3");

            migrationBuilder.RenameIndex(
                name: "IX_AuditQuestions_electricalCableTechnicalId",
                table: "AuditQuestions",
                newName: "IX_AuditQuestions_environmentalSiteId2");

            migrationBuilder.RenameIndex(
                name: "IX_AuditQuestions_electricalCableCivilId",
                table: "AuditQuestions",
                newName: "IX_AuditQuestions_environmentalSiteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId1",
                table: "AuditQuestions",
                column: "environmentalSiteId1",
                principalTable: "EnvironmentalSiteAudit",
                principalColumn: "environmentalSiteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId2",
                table: "AuditQuestions",
                column: "environmentalSiteId2",
                principalTable: "EnvironmentalSiteAudit",
                principalColumn: "environmentalSiteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId3",
                table: "AuditQuestions",
                column: "environmentalSiteId3",
                principalTable: "EnvironmentalSiteAudit",
                principalColumn: "environmentalSiteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId4",
                table: "AuditQuestions",
                column: "environmentalSiteId4",
                principalTable: "EnvironmentalSiteAudit",
                principalColumn: "environmentalSiteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId5",
                table: "AuditQuestions",
                column: "environmentalSiteId5",
                principalTable: "EnvironmentalSiteAudit",
                principalColumn: "environmentalSiteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
