using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CleanApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialUserDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
