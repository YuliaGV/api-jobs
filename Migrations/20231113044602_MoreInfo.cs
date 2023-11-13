using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_jobs.Migrations
{
    /// <inheritdoc />
    public partial class MoreInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                table: "Job",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 23, 46, 2, 516, DateTimeKind.Local).AddTicks(5270),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 11, 12, 23, 43, 28, 675, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobId",
                keyValue: new Guid("434bb0cc-afba-40f3-a872-980b562d7290"),
                column: "PostingDate",
                value: new DateTime(2023, 11, 12, 23, 46, 2, 516, DateTimeKind.Local).AddTicks(3494));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                table: "Job",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 23, 43, 28, 675, DateTimeKind.Local).AddTicks(7700),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 11, 12, 23, 46, 2, 516, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobId",
                keyValue: new Guid("434bb0cc-afba-40f3-a872-980b562d7290"),
                column: "PostingDate",
                value: new DateTime(2023, 11, 12, 23, 43, 28, 675, DateTimeKind.Local).AddTicks(5869));
        }
    }
}
