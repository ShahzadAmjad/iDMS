using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iDMS.Migrations
{
    public partial class FianlMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationOfWork",
                table: "ElectricalJointingAudit");

            migrationBuilder.DropColumn(
                name: "target",
                table: "ElectricalJointingAudit");

            migrationBuilder.RenameColumn(
                name: "projectName",
                table: "GasTechnicalAudit",
                newName: "projectTitle");

            migrationBuilder.AddColumn<DateTime>(
                name: "targetDate",
                table: "ElectricalJointingAudit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "cardNumber",
                table: "AuditQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "condition",
                table: "AuditQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "expiryDate",
                table: "AuditQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "finishDate",
                table: "AuditQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "specify",
                table: "AuditQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "startDate",
                table: "AuditQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "targetDate",
                table: "ElectricalJointingAudit");

            migrationBuilder.DropColumn(
                name: "cardNumber",
                table: "AuditQuestions");

            migrationBuilder.DropColumn(
                name: "condition",
                table: "AuditQuestions");

            migrationBuilder.DropColumn(
                name: "expiryDate",
                table: "AuditQuestions");

            migrationBuilder.DropColumn(
                name: "finishDate",
                table: "AuditQuestions");

            migrationBuilder.DropColumn(
                name: "specify",
                table: "AuditQuestions");

            migrationBuilder.DropColumn(
                name: "startDate",
                table: "AuditQuestions");

            migrationBuilder.RenameColumn(
                name: "projectTitle",
                table: "GasTechnicalAudit",
                newName: "projectName");

            migrationBuilder.AddColumn<string>(
                name: "LocationOfWork",
                table: "ElectricalJointingAudit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "target",
                table: "ElectricalJointingAudit",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
