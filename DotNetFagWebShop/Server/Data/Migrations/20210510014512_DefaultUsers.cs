using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetFagWebShop.Server.Data.Migrations
{
    public partial class DefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b07ae867-921f-4faf-bf16-481b6f5297f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b3d8fb3e-ee72-40c2-99ad-6893a7f62edf");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateIn", "DateOut", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 206, DateTimeKind.Local).AddTicks(6378), new DateTime(2021, 5, 10, 3, 45, 11, 206, DateTimeKind.Local).AddTicks(4816), new DateTime(2021, 5, 10, 3, 45, 11, 206, DateTimeKind.Local).AddTicks(5457), new DateTime(2021, 5, 10, 3, 45, 11, 206, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateIn", "DateOut", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 206, DateTimeKind.Local).AddTicks(8210), new DateTime(2021, 5, 10, 3, 45, 11, 206, DateTimeKind.Local).AddTicks(8197), new DateTime(2021, 5, 10, 3, 45, 11, 206, DateTimeKind.Local).AddTicks(8207), new DateTime(2021, 5, 10, 3, 45, 11, 206, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 207, DateTimeKind.Local).AddTicks(2313), new DateTime(2021, 5, 10, 3, 45, 11, 207, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 207, DateTimeKind.Local).AddTicks(2333), new DateTime(2021, 5, 10, 3, 45, 11, 207, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 207, DateTimeKind.Local).AddTicks(2338), new DateTime(2021, 5, 10, 3, 45, 11, 207, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 207, DateTimeKind.Local).AddTicks(9078), new DateTime(2021, 5, 10, 3, 45, 11, 207, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 207, DateTimeKind.Local).AddTicks(9102), new DateTime(2021, 5, 10, 3, 45, 11, 207, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 208, DateTimeKind.Local).AddTicks(7153), new DateTime(2021, 5, 10, 3, 45, 11, 208, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 208, DateTimeKind.Local).AddTicks(7184), new DateTime(2021, 5, 10, 3, 45, 11, 208, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 208, DateTimeKind.Local).AddTicks(7189), new DateTime(2021, 5, 10, 3, 45, 11, 208, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2734), new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2768), new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2774), new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2779), new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2785), new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2790), new DateTime(2021, 5, 10, 3, 45, 11, 209, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 5, 10, 3, 45, 11, 202, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 210, DateTimeKind.Local).AddTicks(239), new DateTime(2021, 5, 10, 3, 45, 11, 210, DateTimeKind.Local).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 3, 45, 11, 210, DateTimeKind.Local).AddTicks(264), new DateTime(2021, 5, 10, 3, 45, 11, 210, DateTimeKind.Local).AddTicks(266) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateIn", "DateOut", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(4949), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(3526), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(4077), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateIn", "DateOut", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(6688), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(6675), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(6685), new DateTime(2021, 5, 10, 2, 51, 55, 605, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1825), new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1845), new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1851), new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(8272), new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(8294), new DateTime(2021, 5, 10, 2, 51, 55, 606, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2279), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2299), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2305), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7165), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7185), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7191), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7196), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7201), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7206), new DateTime(2021, 5, 10, 2, 51, 55, 607, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 5, 10, 2, 51, 55, 601, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 608, DateTimeKind.Local).AddTicks(4093), new DateTime(2021, 5, 10, 2, 51, 55, 608, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 51, 55, 608, DateTimeKind.Local).AddTicks(4113), new DateTime(2021, 5, 10, 2, 51, 55, 608, DateTimeKind.Local).AddTicks(4115) });
        }
    }
}
