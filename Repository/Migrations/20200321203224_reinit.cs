using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class reinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "DeliveryId", "CaseCount", "DeliveryTime", "DriverId" },
                values: new object[,]
                {
                    { 6, 34, "12:45:00", 3 },
                    { 25, 295, "12:00:00", 3 },
                    { 24, 100, "12:15:00", 3 },
                    { 23, 125, "06:00:00", 3 },
                    { 22, 75, "06:30:00", 3 },
                    { 21, 72, "13:00:00", 3 },
                    { 19, 70, "15:00:00", 3 },
                    { 18, 50, "12:15:00", 3 },
                    { 17, 90, "14:15:00", 3 },
                    { 16, 60, "13:45:00", 3 },
                    { 20, 65, "13:45:00", 3 },
                    { 14, 37, "7:45:00", 3 },
                    { 15, 20, "10:15:00", 3 },
                    { 8, 65, "12:45:00", 3 },
                    { 9, 89, "10:30:00", 3 },
                    { 10, 34, "9:45:00", 3 },
                    { 7, 78, "05:15:00", 3 },
                    { 12, 87, "9:15:00", 3 },
                    { 13, 58, "8:00:00", 3 },
                    { 11, 45, "11:15:00", 3 }
                });

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 1, 1 },
                column: "ScheduleStopId",
                value: 76);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 2, 2 },
                column: "ScheduleStopId",
                value: 83);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 3, 3 },
                column: "ScheduleStopId",
                value: 91);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 4, 4 },
                column: "ScheduleStopId",
                value: 99);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 5, 5 },
                column: "ScheduleStopId",
                value: 106);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 6, 6 },
                column: "ScheduleStopId",
                value: 113);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 7, 7 },
                column: "ScheduleStopId",
                value: 121);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 8, 8 },
                column: "ScheduleStopId",
                value: 129);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 9, 9 },
                column: "ScheduleStopId",
                value: 136);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 10, 10 },
                column: "ScheduleStopId",
                value: 143);

            migrationBuilder.InsertData(
                table: "ScheduleStops",
                columns: new[] { "ScheduleId", "StopId", "ScheduleStopId" },
                values: new object[,]
                {
                    { 1, 11, 77 },
                    { 2, 12, 84 },
                    { 3, 13, 92 },
                    { 6, 14, 114 },
                    { 7, 15, 122 }
                });

            migrationBuilder.InsertData(
                table: "Stops",
                columns: new[] { "StopId", "DayOfWeek", "DeliveryId", "EmployeeId", "StoreId", "Type" },
                values: new object[,]
                {
                    { 34, 3, null, 1, 4, "Write Order" },
                    { 19, 2, null, 1, 6, "Write Order" },
                    { 20, 2, null, 1, 7, "Write Order" },
                    { 24, 2, null, 2, 2, "Merchandise" },
                    { 70, 5, null, 2, 10, "Merchandise" },
                    { 69, 5, null, 2, 9, "Merchandise" },
                    { 25, 2, null, 2, 3, "Merchandise" },
                    { 68, 5, null, 2, 8, "Merchandise" },
                    { 64, 5, null, 1, 4, "Write Order" },
                    { 55, 4, null, 2, 3, "Merchandise" },
                    { 54, 4, null, 2, 2, "Merchandise" },
                    { 53, 4, null, 2, 1, "Merchandise" },
                    { 50, 4, null, 1, 7, "Write Order" },
                    { 49, 4, null, 1, 6, "Write Order" },
                    { 40, 3, null, 2, 10, "Merchandise" },
                    { 39, 3, null, 2, 9, "Merchandise" },
                    { 38, 3, null, 2, 8, "Merchandise" },
                    { 35, 3, null, 1, 5, "Write Order" },
                    { 65, 5, null, 1, 5, "Write Order" },
                    { 23, 2, null, 2, 1, "Merchandise" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleStops",
                columns: new[] { "ScheduleId", "StopId", "ScheduleStopId" },
                values: new object[,]
                {
                    { 10, 70, 149 },
                    { 12, 39, 39 },
                    { 8, 38, 132 },
                    { 12, 38, 38 },
                    { 5, 35, 109 },
                    { 11, 35, 35 },
                    { 6, 34, 116 },
                    { 4, 34, 102 },
                    { 9, 39, 139 },
                    { 11, 34, 34 },
                    { 12, 25, 25 },
                    { 2, 24, 85 },
                    { 12, 24, 24 },
                    { 1, 23, 78 },
                    { 12, 23, 23 },
                    { 7, 20, 123 },
                    { 11, 20, 20 },
                    { 3, 25, 93 },
                    { 12, 40, 40 },
                    { 10, 40, 146 },
                    { 11, 49, 49 },
                    { 9, 69, 142 },
                    { 12, 69, 69 },
                    { 8, 68, 135 },
                    { 12, 68, 68 },
                    { 5, 65, 112 },
                    { 11, 65, 65 },
                    { 6, 64, 119 },
                    { 4, 64, 105 },
                    { 11, 64, 64 },
                    { 3, 55, 96 },
                    { 12, 55, 55 },
                    { 2, 54, 88 },
                    { 12, 54, 54 },
                    { 1, 53, 80 },
                    { 12, 53, 53 },
                    { 7, 50, 126 },
                    { 11, 50, 50 },
                    { 11, 19, 19 },
                    { 12, 70, 70 }
                });

            migrationBuilder.InsertData(
                table: "Stops",
                columns: new[] { "StopId", "DayOfWeek", "DeliveryId", "EmployeeId", "StoreId", "Type" },
                values: new object[,]
                {
                    { 75, 5, 25, 3, 7, "Drop Off" },
                    { 74, 5, 24, 3, 6, "Drop Off" },
                    { 36, 3, 14, 2, 6, "Delivery" },
                    { 43, 3, 13, 3, 3, "Drop Off" },
                    { 33, 3, 13, 1, 3, "Delivery" },
                    { 42, 3, 12, 3, 2, "Drop Off" },
                    { 32, 3, 12, 1, 2, "Delivery" },
                    { 41, 3, 11, 3, 1, "Drop Off" },
                    { 31, 3, 11, 1, 1, "Delivery" },
                    { 44, 3, 14, 3, 6, "Drop Off" },
                    { 30, 2, 10, 3, 5, "Drop Off" },
                    { 29, 2, 9, 3, 4, "Drop Off" },
                    { 21, 2, 9, 2, 4, "Delivery" },
                    { 28, 2, 8, 3, 10, "Drop Off" },
                    { 18, 2, 8, 1, 10, "Delivery" },
                    { 27, 2, 7, 3, 9, "Drop Off" },
                    { 17, 2, 7, 1, 9, "Delivery" },
                    { 26, 2, 6, 3, 8, "Drop Off" },
                    { 22, 2, 10, 2, 5, "Delivery" },
                    { 67, 5, 25, 2, 7, "Delivery" },
                    { 37, 3, 15, 2, 7, "Delivery" },
                    { 46, 4, 16, 1, 8, "Delivery" },
                    { 66, 5, 24, 2, 6, "Delivery" },
                    { 73, 5, 23, 3, 3, "Drop Off" },
                    { 63, 5, 23, 1, 3, "Delivery" },
                    { 72, 5, 22, 3, 2, "Drop Off" },
                    { 62, 5, 22, 1, 2, "Delivery" },
                    { 71, 5, 21, 3, 1, "Drop Off" },
                    { 61, 5, 21, 1, 1, "Delivery" },
                    { 45, 3, 15, 3, 7, "Drop Off" },
                    { 60, 4, 20, 3, 5, "Drop Off" },
                    { 59, 4, 19, 3, 4, "Drop Off" },
                    { 51, 4, 19, 2, 4, "Delivery" },
                    { 58, 4, 18, 3, 10, "Drop Off" },
                    { 48, 4, 18, 1, 10, "Delivery" },
                    { 57, 4, 17, 3, 9, "Drop Off" },
                    { 47, 4, 17, 1, 9, "Delivery" },
                    { 56, 4, 16, 3, 8, "Drop Off" },
                    { 52, 4, 20, 2, 5, "Delivery" },
                    { 16, 2, 6, 1, 8, "Delivery" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleStops",
                columns: new[] { "ScheduleId", "StopId", "ScheduleStopId" },
                values: new object[,]
                {
                    { 11, 16, 16 },
                    { 12, 52, 52 },
                    { 4, 59, 104 },
                    { 13, 59, 59 },
                    { 4, 51, 103 },
                    { 12, 51, 51 },
                    { 10, 58, 148 },
                    { 13, 58, 58 },
                    { 5, 52, 110 },
                    { 10, 48, 147 },
                    { 9, 57, 141 },
                    { 13, 57, 57 },
                    { 9, 47, 140 },
                    { 11, 47, 47 },
                    { 8, 56, 134 },
                    { 6, 56, 118 },
                    { 13, 56, 56 },
                    { 11, 48, 48 },
                    { 8, 46, 133 },
                    { 13, 60, 60 },
                    { 11, 61, 61 },
                    { 7, 67, 127 },
                    { 12, 67, 67 },
                    { 6, 74, 120 },
                    { 13, 74, 74 },
                    { 12, 66, 66 },
                    { 3, 73, 98 },
                    { 13, 73, 73 },
                    { 5, 60, 111 },
                    { 3, 63, 97 },
                    { 2, 72, 90 },
                    { 13, 72, 72 },
                    { 2, 62, 89 },
                    { 11, 62, 62 },
                    { 1, 71, 82 },
                    { 13, 71, 71 },
                    { 1, 61, 81 },
                    { 11, 63, 63 },
                    { 11, 46, 46 },
                    { 7, 45, 125 },
                    { 13, 45, 45 },
                    { 4, 29, 101 },
                    { 13, 29, 29 },
                    { 4, 21, 100 },
                    { 12, 21, 21 },
                    { 10, 28, 145 },
                    { 13, 28, 28 },
                    { 10, 18, 144 },
                    { 12, 22, 22 },
                    { 11, 18, 18 },
                    { 13, 27, 27 },
                    { 9, 17, 137 },
                    { 11, 17, 17 },
                    { 8, 26, 131 },
                    { 6, 26, 115 },
                    { 13, 26, 26 },
                    { 8, 16, 130 },
                    { 9, 27, 138 },
                    { 5, 22, 107 },
                    { 13, 30, 30 },
                    { 5, 30, 108 },
                    { 7, 37, 124 },
                    { 12, 37, 37 },
                    { 6, 44, 117 },
                    { 13, 44, 44 },
                    { 12, 36, 36 },
                    { 3, 43, 95 },
                    { 13, 43, 43 },
                    { 3, 33, 94 },
                    { 11, 33, 33 },
                    { 2, 42, 87 },
                    { 13, 42, 42 },
                    { 2, 32, 86 },
                    { 11, 32, 32 },
                    { 1, 41, 79 },
                    { 13, 41, 41 },
                    { 1, 31, 78 },
                    { 11, 31, 31 },
                    { 13, 75, 75 },
                    { 7, 75, 128 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 1, 41 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 1, 53 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 1, 61 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 1, 71 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 2, 32 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 2, 42 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 2, 54 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 2, 62 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 2, 72 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 3, 33 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 3, 43 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 3, 55 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 3, 63 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 3, 73 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 4, 21 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 4, 29 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 4, 34 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 4, 51 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 4, 59 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 4, 64 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 5, 22 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 5, 30 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 5, 52 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 5, 60 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 5, 65 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 6, 26 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 6, 34 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 6, 44 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 6, 56 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 6, 64 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 6, 74 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 7, 20 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 7, 37 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 7, 45 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 7, 50 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 7, 67 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 7, 75 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 8, 26 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 8, 38 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 8, 46 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 8, 56 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 8, 68 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 9, 27 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 9, 39 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 9, 47 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 9, 57 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 9, 69 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 10, 18 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 10, 28 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 10, 40 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 10, 48 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 10, 58 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 10, 70 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 16 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 17 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 18 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 19 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 20 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 31 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 32 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 33 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 34 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 35 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 46 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 47 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 48 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 49 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 50 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 61 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 62 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 63 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 64 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 11, 65 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 21 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 22 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 23 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 24 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 25 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 36 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 37 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 38 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 39 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 40 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 51 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 52 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 53 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 54 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 55 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 66 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 67 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 68 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 69 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 12, 70 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 26 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 27 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 28 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 29 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 30 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 41 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 42 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 43 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 44 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 45 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 56 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 57 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 58 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 59 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 60 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 71 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 72 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 73 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 74 });

            migrationBuilder.DeleteData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 13, 75 });

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Stops",
                keyColumn: "StopId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 1, 1 },
                column: "ScheduleStopId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 2, 2 },
                column: "ScheduleStopId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 3, 3 },
                column: "ScheduleStopId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 4, 4 },
                column: "ScheduleStopId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 5, 5 },
                column: "ScheduleStopId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 6, 6 },
                column: "ScheduleStopId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 7, 7 },
                column: "ScheduleStopId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 8, 8 },
                column: "ScheduleStopId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 9, 9 },
                column: "ScheduleStopId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ScheduleStops",
                keyColumns: new[] { "ScheduleId", "StopId" },
                keyValues: new object[] { 10, 10 },
                column: "ScheduleStopId",
                value: 16);
        }
    }
}
