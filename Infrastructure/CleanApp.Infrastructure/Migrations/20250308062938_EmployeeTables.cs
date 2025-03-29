using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CleanApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b10e3223-43a8-4646-be95-83c172710dc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf40b13b-485d-464c-b0dd-70d209daf199");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b52ec8a-bcfb-4063-947b-a45f8e5625f0", "c752955c-af2a-4151-8e74-f9edcb31aa04" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b52ec8a-bcfb-4063-947b-a45f8e5625f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c752955c-af2a-4151-8e74-f9edcb31aa04");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 8, 6, 29, 37, 999, DateTimeKind.Utc).AddTicks(1329)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 8, 6, 29, 37, 999, DateTimeKind.Utc).AddTicks(2458)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08ed5adf-9a1d-40c1-9260-5556d197f09f", "1", "User", "USER" },
                    { "ce5054b8-f868-443b-91c1-9e00eb3933a0", "1", "SuperAdmin", "SUPERADMIN" },
                    { "d38ccad9-994b-485d-86a1-a5b665fd3053", "1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedBy", "UpdatedDate", "UserName" },
                values: new object[] { "0faea7d4-808b-481c-abaf-9866f1763957", 0, "30e90a6e-4e73-45c8-b65c-0b20a8fcede3", "Maual", new DateTime(2025, 3, 8, 1, 29, 37, 534, DateTimeKind.Local).AddTicks(6152), "admin@system.com", true, "System", true, false, "Admin", false, null, "ADMIN@SYSTEM.COM", "ADMIN@SYSTEM.COM", "AQAAAAIAAYagAAAAEKTWwambTu+E/EK5NIzysXZYUV+xvTyGUKRwBIOYcqj9ggl4uoDPsukTecIrtEjMzQ==", "2027708556", false, "c1820369-42ac-429a-8b24-4fc2ffb4bb0c", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@system.com" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Guid", "IsActive" },
                values: new object[,]
                {
                    { 1, "Manual", new DateTime(2025, 3, 8, 1, 29, 38, 74, DateTimeKind.Local).AddTicks(6884), "Male", new Guid("a13be118-06de-452b-884b-0dec71ab5dad"), true },
                    { 2, "Manual", new DateTime(2025, 3, 8, 1, 29, 38, 74, DateTimeKind.Local).AddTicks(6941), "Female", new Guid("df2febe4-5c44-4126-a83a-2866cb37e7ea"), true },
                    { 3, "Manual", new DateTime(2025, 3, 8, 1, 29, 38, 74, DateTimeKind.Local).AddTicks(6945), "Other", new Guid("e2c68f8a-d93a-4e89-9fc8-a7a0bfa502ff"), true }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ce5054b8-f868-443b-91c1-9e00eb3933a0", "0faea7d4-808b-481c-abaf-9866f1763957" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08ed5adf-9a1d-40c1-9260-5556d197f09f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d38ccad9-994b-485d-86a1-a5b665fd3053");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce5054b8-f868-443b-91c1-9e00eb3933a0", "0faea7d4-808b-481c-abaf-9866f1763957" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce5054b8-f868-443b-91c1-9e00eb3933a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0faea7d4-808b-481c-abaf-9866f1763957");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b52ec8a-bcfb-4063-947b-a45f8e5625f0", "1", "SuperAdmin", "SUPERADMIN" },
                    { "b10e3223-43a8-4646-be95-83c172710dc0", "1", "User", "USER" },
                    { "cf40b13b-485d-464c-b0dd-70d209daf199", "1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedBy", "UpdatedDate", "UserName" },
                values: new object[] { "c752955c-af2a-4151-8e74-f9edcb31aa04", 0, "6c9dffec-fb59-4a46-9dd2-0ad9155bd3fa", "Maual", new DateTime(2025, 3, 7, 14, 46, 9, 264, DateTimeKind.Local).AddTicks(5414), "admin@system.com", true, "System", true, false, "Admin", false, null, "ADMIN@SYSTEM.COM", "ADMIN@SYSTEM.COM", "AQAAAAIAAYagAAAAEKiYQj8K0Wa4wi8jNCB75UwbKVUsLUMycLBgVN3AyayuD8r8NwWKjfqiTdsBNU5XSA==", "2027708556", false, "1c608683-0795-49a0-8bb5-a2863243da8e", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@system.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3b52ec8a-bcfb-4063-947b-a45f8e5625f0", "c752955c-af2a-4151-8e74-f9edcb31aa04" });
        }
    }
}
