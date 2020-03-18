using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    DeliveryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverId = table.Column<int>(nullable: false),
                    CaseCount = table.Column<int>(nullable: false),
                    DeliveryTime = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.DeliveryId);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleId);
                });

            migrationBuilder.CreateTable(
                name: "Stops",
                columns: table => new
                {
                    StopId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    DayOfWeek = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    DeliveryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stops", x => x.StopId);
                    table.ForeignKey(
                        name: "FK_Stops_Deliveries_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "DeliveryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteName = table.Column<string>(nullable: true),
                    ScheduleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteId);
                    table.ForeignKey(
                        name: "FK_Routes_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(nullable: true),
                    PlaceId = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    Lat = table.Column<double>(nullable: false),
                    Long = table.Column<double>(nullable: false),
                    ScheduleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                    table.ForeignKey(
                        name: "FK_Stores_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    RouteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "DeliveryId", "CaseCount", "DeliveryTime", "DriverId" },
                values: new object[,]
                {
                    { 1, 100, new TimeSpan(0, 8, 15, 0, 0), 3 },
                    { 2, 65, new TimeSpan(0, 9, 30, 0, 0), 3 },
                    { 3, 98, new TimeSpan(0, 10, 11, 0, 0), 3 },
                    { 4, 72, new TimeSpan(0, 6, 0, 0, 0), 3 },
                    { 5, 89, new TimeSpan(0, 12, 30, 0, 0), 3 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "Name", "PhoneNumber", "Position", "RouteId", "UserId" },
                values: new object[,]
                {
                    { 1, null, "Aaron Madison", "123-456-7891", "Sales Representative", null, null },
                    { 2, null, "Amanda Miller", "123-456-7891", "Merchandier", null, null },
                    { 3, null, "David Wroblewski", "123-456-7891", "Driver", null, null }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ScheduleId", "EmployeeId", "StoreId" },
                values: new object[,]
                {
                    { 13, 3, null },
                    { 12, 2, null },
                    { 11, 1, null },
                    { 10, null, 10 },
                    { 9, null, 9 },
                    { 8, null, 8 },
                    { 5, null, 5 },
                    { 6, null, 6 },
                    { 4, null, 4 },
                    { 3, null, 3 },
                    { 2, null, 2 },
                    { 1, null, 1 },
                    { 7, null, 7 }
                });

            migrationBuilder.InsertData(
                table: "Stops",
                columns: new[] { "StopId", "DayOfWeek", "DeliveryId", "EmployeeId", "StoreId", "Type" },
                values: new object[,]
                {
                    { 9, 1, null, 2, 9, "Merchandise" },
                    { 4, 1, null, 1, 4, "Write Order" },
                    { 5, 1, null, 1, 5, "Write Order" },
                    { 8, 1, null, 2, 8, "Merchandise" },
                    { 10, 1, null, 2, 10, "Merchandise" }
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "RouteName", "ScheduleId" },
                values: new object[,]
                {
                    { 3, "CWMLAC", 13 },
                    { 1, "CWMLAA", 11 },
                    { 2, "CWMLAB", 12 }
                });

            migrationBuilder.InsertData(
                table: "Stops",
                columns: new[] { "StopId", "DayOfWeek", "DeliveryId", "EmployeeId", "StoreId", "Type" },
                values: new object[,]
                {
                    { 15, 1, 5, 3, 7, "Drop Off" },
                    { 7, 1, 5, 2, 7, "Delivery" },
                    { 14, 1, 4, 3, 6, "Drop Off" },
                    { 1, 1, 1, 1, 1, "Delivery" },
                    { 13, 1, 3, 3, 3, "Drop Off" },
                    { 3, 1, 3, 1, 3, "Delivery" },
                    { 12, 1, 2, 3, 2, "Drop Off" },
                    { 2, 1, 2, 1, 2, "Delivery" },
                    { 11, 1, 1, 3, 1, "Drop Off" },
                    { 6, 1, 4, 2, 6, "Delivery" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Lat", "Long", "PlaceId", "ScheduleId", "StoreName", "StreetAddress" },
                values: new object[,]
                {
                    { 1, 42.984206999999998, -87.912901000000005, "ChIJfZyRV2oXBYgR_hLJNn-fnEg", 1, "Pick n Save Holt", "250 W Holt Ave, Milwaukee, WI, 53207" },
                    { 3, 42.997154000000002, -88.049858, "ChIJ-wwouYMPBYgRugMGerzM4Ec", 3, "Pick n Save Cleveland", "2625 S 108th St, West Allis, WI 53227" },
                    { 4, 42.997076, -88.045524, "ChIJuXhmDoQPBYgRK8eTQCbhzRw", 4, "Target West Allis", "2600 S 108th St, West Allis, WI 53227" },
                    { 5, 42.939061000000002, -88.045790999999994, "ChIJ8fooCWQOBYgRXnOW9RqNh68", 5, "Pick n Save Hales Corners", "5800 S 108th St, Hales Corners, WI 53130" },
                    { 6, 42.939061000000002, -88.045790999999994, "ChIJn_sIpcMIBYgRoDPHQpNiEh4", 6, "Pick n Save New Berlin", "15445 W National Ave, New Berlin, WI 53151" },
                    { 7, 42.908267000000002, -88.125995000000003, "ChIJFV_PrMsLBYgRFkmNWGjYHu0", 7, "Pick n Save Muskego", "Janesville Rd S74 W17005, Muskego, WI 53150" },
                    { 8, 42.896918999999997, -87.915362999999999, "ChIJST_O6UIUBYgRJctdFiQ0ofw", 8, "Woodmans Oak Creek", "8131 S Howell Ave, Oak Creek, WI 53154" },
                    { 9, 42.960138999999998, -88.044126000000006, "ChIJk_y7zFQOBYgRew-_R_fb4nc", 9, "Walmart Layton Ave", "10600 W Layton Ave, Greenfield, WI 53228" },
                    { 10, 42.926501000000002, -88.110527000000005, "ChIJi5-Z_t0LBYgR_IeEp3884As", 10, "Walmart Muskego", "W159s6530 Moorland Rd, Muskego, WI 53150" },
                    { 2, 42.968153999999998, -88.009032000000005, "ChIJpUBh1isQBYgR1nJjjs36yVE", 2, "Pick n Save Coldspring", "4279 S 76th St, Greenfield, WI 53220" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RouteId",
                table: "Employees",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_ScheduleId",
                table: "Routes",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Stops_DeliveryId",
                table: "Stops",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_ScheduleId",
                table: "Stores",
                column: "ScheduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Stops");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Schedules");
        }
    }
}
