using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11cbc596-3709-49b8-ad03-b53afd2e9a0f", "7eccba22-e466-4c6d-a93d-627b5d55eedf", "Administrator", "ADMINISTRATOR" },
                    { "d979dde0-1f98-4e30-a010-524d41d6b16d", "c456e242-87a6-4817-b055-d4445ee31b3a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2685e98b-d5a1-499b-b189-588003018514", 0, "728e2431-8390-4a25-87b6-2754e99fd0dc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBvS+ifzas+SWnoFlsDhGGAjWtYiErOJ1NgHisnbwoWwV+FO3TljbXY0SLDvnjIMxg==", null, false, "6360b4cc-09a8-4f40-aa8c-0bac0a58b74a", null, false, "admin@localhost.com" },
                    { "eb41f049-e323-46eb-8477-c530801d97bf", 0, "6e21c24f-1901-4de1-a5f8-b83b49737c0a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBcDA9huuKhp1fXa0auODHYsX7bUVtFpi1KXmzfT4rd0X10a2fQkfeQ1uD8hlbenPA==", null, false, "669968fe-8114-48ab-8ffe-28f35dff004b", null, false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11cbc596-3709-49b8-ad03-b53afd2e9a0f", "2685e98b-d5a1-499b-b189-588003018514" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d979dde0-1f98-4e30-a010-524d41d6b16d", "eb41f049-e323-46eb-8477-c530801d97bf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11cbc596-3709-49b8-ad03-b53afd2e9a0f", "2685e98b-d5a1-499b-b189-588003018514" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d979dde0-1f98-4e30-a010-524d41d6b16d", "eb41f049-e323-46eb-8477-c530801d97bf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11cbc596-3709-49b8-ad03-b53afd2e9a0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d979dde0-1f98-4e30-a010-524d41d6b16d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2685e98b-d5a1-499b-b189-588003018514");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb41f049-e323-46eb-8477-c530801d97bf");
        }
    }
}
