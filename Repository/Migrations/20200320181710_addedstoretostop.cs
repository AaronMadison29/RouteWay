using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class addedstoretostop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stops_StoreId",
                table: "Stops",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stops_Stores_StoreId",
                table: "Stops",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stops_Stores_StoreId",
                table: "Stops");

            migrationBuilder.DropIndex(
                name: "IX_Stops_StoreId",
                table: "Stops");
        }
    }
}
