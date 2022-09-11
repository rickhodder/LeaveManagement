using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class moreuserstuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11cbc596-3709-49b8-ad03-b53afd2e9a0f",
                column: "ConcurrencyStamp",
                value: "522e9e54-ba01-4b09-a73a-d681c49e6b6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d979dde0-1f98-4e30-a010-524d41d6b16d",
                column: "ConcurrencyStamp",
                value: "79c9eb93-fe50-4db8-a452-4134c22a9d55");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2685e98b-d5a1-499b-b189-588003018514",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97fd1105-108b-489f-92b2-b25795316186", "AQAAAAEAACcQAAAAELyUCwEzkcbOClMiVeng3tlA7XdkSdHbFO/t5fjFCXmrtuUzeX8SP2YbReh70REDuw==", "da784ccc-b923-4f0c-929d-1003bc913228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb41f049-e323-46eb-8477-c530801d97bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5df7aca-d9ce-4b07-9f2b-fd6dbfb9fa3e", "AQAAAAEAACcQAAAAEN2OK4r8yDuTH/Jltd9pvIAhRM9+2oLecBGTJp8xDD7pfTBJdsUzw4TXa0ooniGHew==", "7200d60e-5a26-47af-9d6c-a5b846cb4459" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11cbc596-3709-49b8-ad03-b53afd2e9a0f",
                column: "ConcurrencyStamp",
                value: "7eccba22-e466-4c6d-a93d-627b5d55eedf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d979dde0-1f98-4e30-a010-524d41d6b16d",
                column: "ConcurrencyStamp",
                value: "c456e242-87a6-4817-b055-d4445ee31b3a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2685e98b-d5a1-499b-b189-588003018514",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "728e2431-8390-4a25-87b6-2754e99fd0dc", "AQAAAAEAACcQAAAAEBvS+ifzas+SWnoFlsDhGGAjWtYiErOJ1NgHisnbwoWwV+FO3TljbXY0SLDvnjIMxg==", "6360b4cc-09a8-4f40-aa8c-0bac0a58b74a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb41f049-e323-46eb-8477-c530801d97bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e21c24f-1901-4de1-a5f8-b83b49737c0a", "AQAAAAEAACcQAAAAEBcDA9huuKhp1fXa0auODHYsX7bUVtFpi1KXmzfT4rd0X10a2fQkfeQ1uD8hlbenPA==", "669968fe-8114-48ab-8ffe-28f35dff004b" });
        }
    }
}
