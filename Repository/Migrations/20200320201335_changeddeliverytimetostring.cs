using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class changeddeliverytimetostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DeliveryTime",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 1,
                column: "DeliveryTime",
                value: "08:15:00");

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 2,
                column: "DeliveryTime",
                value: "09:30:00");

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 3,
                column: "DeliveryTime",
                value: "10:11:00");

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 4,
                column: "DeliveryTime",
                value: "6:30:00");

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 5,
                column: "DeliveryTime",
                value: "12:15:00");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "DeliveryTime",
                table: "Deliveries",
                type: "time",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 1,
                column: "DeliveryTime",
                value: new TimeSpan(0, 8, 15, 0, 0));

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 2,
                column: "DeliveryTime",
                value: new TimeSpan(0, 9, 30, 0, 0));

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 3,
                column: "DeliveryTime",
                value: new TimeSpan(0, 10, 11, 0, 0));

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 4,
                column: "DeliveryTime",
                value: new TimeSpan(0, 6, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 5,
                column: "DeliveryTime",
                value: new TimeSpan(0, 12, 30, 0, 0));
        }
    }
}
