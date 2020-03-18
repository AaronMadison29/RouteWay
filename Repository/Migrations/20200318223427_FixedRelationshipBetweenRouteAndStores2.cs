using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class FixedRelationshipBetweenRouteAndStores2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RouteStores",
                columns: table => new
                {
                    RouteStoreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteStores", x => x.RouteStoreId);
                    table.ForeignKey(
                        name: "FK_RouteStores_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId");
                    table.ForeignKey(
                        name: "FK_RouteStores_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId");
                });

            migrationBuilder.InsertData(
                table: "RouteStores",
                columns: new[] { "RouteStoreId", "RouteId", "StoreId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 28, 3, 8 },
                    { 27, 3, 7 },
                    { 26, 3, 6 },
                    { 25, 3, 5 },
                    { 24, 3, 4 },
                    { 23, 3, 3 },
                    { 22, 3, 2 },
                    { 21, 3, 1 },
                    { 20, 2, 10 },
                    { 19, 2, 9 },
                    { 18, 2, 8 },
                    { 17, 2, 7 },
                    { 16, 2, 6 },
                    { 15, 2, 5 },
                    { 14, 2, 4 },
                    { 13, 2, 3 },
                    { 12, 2, 2 },
                    { 11, 2, 1 },
                    { 10, 1, 10 },
                    { 9, 1, 9 },
                    { 8, 1, 8 },
                    { 7, 1, 7 },
                    { 6, 1, 6 },
                    { 5, 1, 5 },
                    { 4, 1, 4 },
                    { 3, 1, 3 },
                    { 2, 1, 2 },
                    { 29, 3, 9 },
                    { 30, 3, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RouteStores_RouteId",
                table: "RouteStores",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteStores_StoreId",
                table: "RouteStores",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RouteStores");
        }
    }
}
