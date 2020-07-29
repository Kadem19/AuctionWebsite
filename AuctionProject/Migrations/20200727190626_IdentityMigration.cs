using Microsoft.EntityFrameworkCore.Migrations;

namespace AuctionProject.Migrations
{
    public partial class IdentityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04f1e43b-dbae-4d81-a6d2-17e145d2d2fd", "ca1ba75f-4165-47c2-9df9-fe97c7a5ba74", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cd5a92a1-3616-4d5f-9e01-f425f7be23c5", 0, "f4063b73-e6c8-4b72-bf42-7624be154cae", "mccammon96@gmail.com", true, false, null, "MCCAMMON96@GMAIL.COM", "MCCAMMON96@GMAIL.COM", "AQAAAAEAACcQAAAAELnfAQBYYieExvUT1roHnhHpb5rI93mX5WbUF78EdswOqwuTLGvOKqVZpgmfNmmbbQ==", null, false, "", false, "mccammon96@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "cd5a92a1-3616-4d5f-9e01-f425f7be23c5", "04f1e43b-dbae-4d81-a6d2-17e145d2d2fd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cd5a92a1-3616-4d5f-9e01-f425f7be23c5", "04f1e43b-dbae-4d81-a6d2-17e145d2d2fd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04f1e43b-dbae-4d81-a6d2-17e145d2d2fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd5a92a1-3616-4d5f-9e01-f425f7be23c5");
        }
    }
}
