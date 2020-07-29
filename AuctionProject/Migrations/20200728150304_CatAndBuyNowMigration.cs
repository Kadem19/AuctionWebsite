using Microsoft.EntityFrameworkCore.Migrations;

namespace AuctionProject.Migrations
{
    public partial class CatAndBuyNowMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04f1e43b-dbae-4d81-a6d2-17e145d2d2fd",
                column: "ConcurrencyStamp",
                value: "303fbb7c-dc0b-41e8-8d3d-5841f490d734");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd5a92a1-3616-4d5f-9e01-f425f7be23c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e730b1f-dbef-4fd6-9b00-40c6eef733d4", "AQAAAAEAACcQAAAAEKoBK3mioamNRn/oyT+BfeuehEAyL+NR6J37Zo96u6Y7a4kihZbC/iJXpqSMWa4NHQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04f1e43b-dbae-4d81-a6d2-17e145d2d2fd",
                column: "ConcurrencyStamp",
                value: "0969ee7c-7935-4dae-8a1d-1dca35dda251");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd5a92a1-3616-4d5f-9e01-f425f7be23c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "efaa8f86-060b-46cd-8e83-6c52748f2cb9", "AQAAAAEAACcQAAAAEArL1ooXqu/UoGpUQy7iFhzLu9g9UG2+WW+2sF/C6EnLC63JtLeV8koOSVisre22mA==" });
        }
    }
}
