using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Myxy.NET.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AzDOMetadata",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    BuildCount = table.Column<int>(type: "INTEGER", nullable: false),
                    AnalyzedFailureCount = table.Column<int>(type: "INTEGER", nullable: false),
                    FiledIssueCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Month = table.Column<int>(type: "INTEGER", nullable: false),
                    Day = table.Column<int>(type: "INTEGER", nullable: false),
                    FiscalYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Quarter = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastUpdatedDateTime = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzDOMetadata", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AzDOMetadata");
        }
    }
}
