using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Net5TestApp.DataAccess.Migrations
{
    public partial class AdvertisementAppUserStatusSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AdvertisementAppUserStatuses",
                columns: new[] { "Id", "Definition" },
                values: new object[,]
                {
                    { 1, "Başvurdu" },
                    { 2, "Mülakata Çağrıldı" },
                    { 3, "Olumlu Sonuçlandı" },
                    { 4, "Olumsuz Sonuçlandı" }
                });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 2, 17, 1, 242, DateTimeKind.Local).AddTicks(4314));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdvertisementAppUserStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdvertisementAppUserStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdvertisementAppUserStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdvertisementAppUserStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 27, 22, 57, 6, 495, DateTimeKind.Local).AddTicks(1577));
        }
    }
}
