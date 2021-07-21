using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Myxy.NET.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AzDO",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    AnalyzedBuildCount = table.Column<int>(type: "INTEGER", nullable: false),
                    AnalyzedFailureCount = table.Column<int>(type: "INTEGER", nullable: false),
                    FiledIssueCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Period = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastUpdatedDateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzDO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "E2EOnLinux",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Period = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastUpdatedDateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CompletedBuildCount = table.Column<int>(type: "INTEGER", nullable: false),
                    FiledIssueCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E2EOnLinux", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "E2EOnMac",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Period = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastUpdatedDateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CompletedBuildCount = table.Column<int>(type: "INTEGER", nullable: false),
                    FiledIssueCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E2EOnMac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "E2EOnWindows",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Period = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastUpdatedDateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CompletedBuildCount = table.Column<int>(type: "INTEGER", nullable: false),
                    FiledIssueCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E2EOnWindows", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AzDO");

            migrationBuilder.DropTable(
                name: "E2EOnLinux");

            migrationBuilder.DropTable(
                name: "E2EOnMac");

            migrationBuilder.DropTable(
                name: "E2EOnWindows");
        }
    }
}
