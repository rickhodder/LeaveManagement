using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodAndNumberOfDaysToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfDays",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11cbc596-3709-49b8-ad03-b53afd2e9a0f",
                column: "ConcurrencyStamp",
                value: "0e364ed5-de14-4d67-95c9-1133b3a4f774");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d979dde0-1f98-4e30-a010-524d41d6b16d",
                column: "ConcurrencyStamp",
                value: "52494646-43b7-4b22-9c33-7567f9973557");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2685e98b-d5a1-499b-b189-588003018514",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9606c99e-7090-4461-b054-51156cd4f595", "AQAAAAEAACcQAAAAEDbGffPJzT/0M/Fk261YgtFybvpSZj/U3RX5MjYgYnkqxhqNJNmWG+ovqG9P+2yojg==", "8ec94021-e7d7-4117-b7a9-af65e5f53e34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb41f049-e323-46eb-8477-c530801d97bf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5cde29b-82f7-487b-9b51-54a85dd18da6", "AQAAAAEAACcQAAAAEA5rGPisCh3JgXPiZrH3k2eg0hcnmERaxsHwue3vlonLcccj4Xxn8/5+HgruXUx+7g==", "290341f3-123a-4aca-a5ed-01d781580b7a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfDays",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
    }
}
