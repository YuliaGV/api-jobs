using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_jobs.Migrations
{
    /// <inheritdoc />
    public partial class ColumnIsActiveJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Job",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Job");
        }
    }
}
