using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_jobs.Migrations
{
    /// <inheritdoc />
    public partial class MoreInitialInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                table: "Job",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 23, 46, 49, 380, DateTimeKind.Local).AddTicks(2826),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 11, 12, 23, 46, 2, 516, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobId",
                keyValue: new Guid("434bb0cc-afba-40f3-a872-980b562d7290"),
                column: "PostingDate",
                value: new DateTime(2023, 11, 12, 23, 46, 49, 380, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "JobId", "CategoryId", "Description", "JobType", "Location", "PostingDate", "Title" },
                values: new object[] { new Guid("434bb0cc-afba-40f3-a872-980b562d7291"), new Guid("434bb0cc-afba-40f3-a872-980b562d7279"), "Math Teacher for High School. At least 2 years of experience", 0, "Orlando, FL", new DateTime(2023, 11, 12, 23, 46, 49, 380, DateTimeKind.Local).AddTicks(754), "Math Teacher" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "JobId",
                keyValue: new Guid("434bb0cc-afba-40f3-a872-980b562d7291"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                table: "Job",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 23, 46, 2, 516, DateTimeKind.Local).AddTicks(5270),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 11, 12, 23, 46, 49, 380, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobId",
                keyValue: new Guid("434bb0cc-afba-40f3-a872-980b562d7290"),
                column: "PostingDate",
                value: new DateTime(2023, 11, 12, 23, 46, 2, 516, DateTimeKind.Local).AddTicks(3494));
        }
    }
}
