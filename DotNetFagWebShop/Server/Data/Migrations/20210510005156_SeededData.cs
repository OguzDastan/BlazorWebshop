using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetFagWebShop.Server.Data.Migrations
{
    public partial class SeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f9144d91-e666-4003-b51f-9a0fcfa307f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1f11dfd0-5f4e-4f53-91a7-5d083e7629e8");

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1825), new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1841), "Black", "System" },
                    { 2, "System", new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1845), new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1848), "White", "System" },
                    { 3, "System", new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1851), new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1853), "Red", "System" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "ContactNumber", "CreatedBy", "DateCreated", "DateUpdated", "EmailAddress", "Name", "TaxId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Groove Street", "42424242", "System", new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(8287), "g2g@gmai.com", "John Johnsen", "Denmark", "System" },
                    { 2, "Ringparken 42", "33333333", "System", new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(8294), new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(8297), "ring22@live.com", "Bo Bill", "Denmark", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2279), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2293), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2299), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2302), "Mercedes-Benz", "System" },
                    { 3, "System", new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2305), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2307), "Skoda", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, "System", new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7185), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7188), "Yaris", "System" },
                    { 3, "System", new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7191), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7193), "E200", "System" },
                    { 4, "System", new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7196), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7198), "C200", "System" },
                    { 5, "System", new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7201), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7203), "Octavia", "System" },
                    { 6, "System", new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7206), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7208), "Superb", "System" },
                    { 1, "System", new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7165), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7180), "Aygo", "System" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 5, 10, 2, 51, 55, 601, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ColorId", "CreatedBy", "DateCreated", "DateUpdated", "LicensePlateNumber", "MakeId", "ModelId", "RentalRate", "UpdatedBy", "Vin", "Year" },
                values: new object[] { 1, 1, "System", new DateTime(2021, 5, 10, 2, 51, 55, 608, DateTimeKind.Local).AddTicks(4093), new DateTime(2021, 5, 10, 2, 51, 55, 608, DateTimeKind.Local).AddTicks(4108), "AB 123 22", 1, 1, 1499.95, "System", "SADLKASJLKDLJKASDJKASLKJDKAS", 2018 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ColorId", "CreatedBy", "DateCreated", "DateUpdated", "LicensePlateNumber", "MakeId", "ModelId", "RentalRate", "UpdatedBy", "Vin", "Year" },
                values: new object[] { 2, 2, "System", new DateTime(2021, 5, 10, 2, 51, 55, 608, DateTimeKind.Local).AddTicks(4113), new DateTime(2021, 5, 10, 2, 51, 55, 608, DateTimeKind.Local).AddTicks(4115), "ZE 321 44", 2, 2, 2499.9499999999998, "System", "OPSAIDPOASFIPPIOOPFASI", 2020 });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CreatedBy", "CustomerId", "DateCreated", "DateIn", "DateOut", "DateUpdated", "UpdatedBy", "VehicleId" },
                values: new object[] { 1, "System", 1, new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(4949), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(3526), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(4077), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(5393), "System", 1 });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CreatedBy", "CustomerId", "DateCreated", "DateIn", "DateOut", "DateUpdated", "UpdatedBy", "VehicleId" },
                values: new object[] { 2, "System", 2, new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(6688), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(6675), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(6685), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(6690), "System", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "72aeb46e-fb73-4774-a97b-16df675ead77");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "57817ef4-7d69-48d8-983e-d7746cdf03d5");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 5, 10, 2, 23, 55, 620, DateTimeKind.Local).AddTicks(3598));
        }
    }
}
