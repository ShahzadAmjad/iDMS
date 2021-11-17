using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iDMS.Migrations
{
    public partial class iDMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    HealthSafetyId = table.Column<int>(type: "int", nullable: true),
                    environmentalSiteId = table.Column<int>(type: "int", nullable: true),
                    environmentalSiteId1 = table.Column<int>(type: "int", nullable: true),
                    environmentalSiteId2 = table.Column<int>(type: "int", nullable: true),
                    environmentalSiteId3 = table.Column<int>(type: "int", nullable: true),
                    environmentalSiteId4 = table.Column<int>(type: "int", nullable: true),
                    environmentalSiteId5 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditQuestions", x => x.questionId);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId",
                        column: x => x.environmentalSiteId,
                        principalTable: "EnvironmentalSiteAudit",
                        principalColumn: "environmentalSiteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId1",
                        column: x => x.environmentalSiteId1,
                        principalTable: "EnvironmentalSiteAudit",
                        principalColumn: "environmentalSiteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId2",
                        column: x => x.environmentalSiteId2,
                        principalTable: "EnvironmentalSiteAudit",
                        principalColumn: "environmentalSiteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId3",
                        column: x => x.environmentalSiteId3,
                        principalTable: "EnvironmentalSiteAudit",
                        principalColumn: "environmentalSiteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId4",
                        column: x => x.environmentalSiteId4,
                        principalTable: "EnvironmentalSiteAudit",
                        principalColumn: "environmentalSiteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_EnvironmentalSiteAudit_environmentalSiteId5",
                        column: x => x.environmentalSiteId5,
                        principalTable: "EnvironmentalSiteAudit",
                        principalColumn: "environmentalSiteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditQuestions_HealthSafetyAudit_HealthSafetyId",
                        column: x => x.HealthSafetyId,
                        principalTable: "HealthSafetyAudit",
                        principalColumn: "HealthSafetyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_environmentalSiteId",
                table: "AuditQuestions",
                column: "environmentalSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_environmentalSiteId1",
                table: "AuditQuestions",
                column: "environmentalSiteId1");

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_environmentalSiteId2",
                table: "AuditQuestions",
                column: "environmentalSiteId2");

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_environmentalSiteId3",
                table: "AuditQuestions",
                column: "environmentalSiteId3");

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_environmentalSiteId4",
                table: "AuditQuestions",
                column: "environmentalSiteId4");

            migrationBuilder.CreateIndex(
                name: "IX_AuditQuestions_environmentalSiteId5",
                table: "AuditQuestions",
                column: "environmentalSiteId5");

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
                name: "EnvironmentalSiteAudit");

            migrationBuilder.DropTable(
                name: "HealthSafetyAudit");
        }
    }
}
