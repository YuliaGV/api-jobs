using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_jobs.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                table: "Job",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 12, 21, 41, 10, 828, DateTimeKind.Local).AddTicks(8591),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Job",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("434bb0cc-afba-40f3-a872-980b562d7279"), "From teaching roles to administrative positions, find your place in shaping the future. Explore diverse jobs that contribute to educational excellence and student success", "Education" },
                    { new Guid("434bb0cc-afba-40f3-a872-980b562d7280"), "From nursing and medical practitioners to administrative roles, discover diverse positions that contribute to the well-being of individuals and communities", "Healthcare" }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "JobId", "CategoryId", "Description", "JobType", "Location", "PostingDate", "Title" },
                values: new object[] { new Guid("434bb0cc-afba-40f3-a872-980b562d7290"), new Guid("434bb0cc-afba-40f3-a872-980b562d7280"), "Nurse for the intensive care area in a large hospital in New York. At least 3 years of experience", 0, "Miami, FL", new DateTime(2023, 11, 12, 21, 41, 10, 828, DateTimeKind.Local).AddTicks(4128), "Registered Nurse" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("434bb0cc-afba-40f3-a872-980b562d7279"));

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "JobId",
                keyValue: new Guid("434bb0cc-afba-40f3-a872-980b562d7290"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("434bb0cc-afba-40f3-a872-980b562d7280"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                table: "Job",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2023, 11, 12, 21, 41, 10, 828, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Job",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
