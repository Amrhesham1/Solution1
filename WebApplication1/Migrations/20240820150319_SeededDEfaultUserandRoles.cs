using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OFlow_Api.Migrations
{
    /// <inheritdoc />
    public partial class SeededDEfaultUserandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8218aae3-3ae8-4014-a970-c0f845fbf543", null, "User", "USER" },
                    { "abf1b18d-ef95-4550-9b00-ec28ed98ef9a", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0e044385-6582-4d16-90f7-848f5e93f30f", 0, "9e08574a-217f-4a99-989c-3497100530e5", "admin@bookstore.com", false, "system", "admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEDjEsiWttOXVXEczw5Ust1W5vQP9sf1Gcn7Xzm63SLlvS1xUJUkCZ4X/ck/YS28xNg==", null, false, "53a6c2ef-1a5d-40e6-af8a-1c970e0c9816", false, "admin@bookstore.com" },
                    { "8d8389e0-b360-4bc9-97d3-a2618e3cd18c", 0, "c68b7581-c328-4752-8b17-64442f7fe1d3", "User@bookstore.com", false, "system", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEJQr6yPTQhYStVNQOiofuAIyNC7EatSRDREnD0P3+kCCT9Ezh25qAIJPnEz6mzgJjA==", null, false, "81f73145-8a9c-4360-92ba-da4dca4457c3", false, "User@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "abf1b18d-ef95-4550-9b00-ec28ed98ef9a", "0e044385-6582-4d16-90f7-848f5e93f30f" },
                    { "8218aae3-3ae8-4014-a970-c0f845fbf543", "8d8389e0-b360-4bc9-97d3-a2618e3cd18c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "abf1b18d-ef95-4550-9b00-ec28ed98ef9a", "0e044385-6582-4d16-90f7-848f5e93f30f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8218aae3-3ae8-4014-a970-c0f845fbf543", "8d8389e0-b360-4bc9-97d3-a2618e3cd18c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8218aae3-3ae8-4014-a970-c0f845fbf543");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abf1b18d-ef95-4550-9b00-ec28ed98ef9a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e044385-6582-4d16-90f7-848f5e93f30f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d8389e0-b360-4bc9-97d3-a2618e3cd18c");
        }
    }
}
