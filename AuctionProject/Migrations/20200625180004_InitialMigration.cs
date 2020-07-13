using Microsoft.EntityFrameworkCore.Migrations;

namespace AuctionProject.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auctions",
                columns: table => new
                {
                    AuctionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.AuctionId);
                });

            migrationBuilder.CreateTable(
                name: "AuctionBids",
                columns: table => new
                {
                    AuctionBidId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    BidAmount = table.Column<double>(nullable: false),
                    AuctionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionBids", x => x.AuctionBidId);
                    table.ForeignKey(
                        name: "FK_AuctionBids_Auctions_AuctionId",
                        column: x => x.AuctionId,
                        principalTable: "Auctions",
                        principalColumn: "AuctionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Auctions",
                columns: new[] { "AuctionId", "ProductId", "SellerId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Auctions",
                columns: new[] { "AuctionId", "ProductId", "SellerId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "AuctionBids",
                columns: new[] { "AuctionBidId", "AuctionId", "BidAmount", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 18.5, 1 },
                    { 3, 1, 20.300000000000001, 2 },
                    { 2, 2, 20.0, 2 },
                    { 4, 2, 23.5, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuctionBids_AuctionId",
                table: "AuctionBids",
                column: "AuctionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuctionBids");

            migrationBuilder.DropTable(
                name: "Auctions");
        }
    }
}
