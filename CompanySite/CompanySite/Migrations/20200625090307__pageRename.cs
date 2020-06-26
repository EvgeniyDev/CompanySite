using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanySite.Migrations
{
    public partial class _pageRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85011dea-56dd-4ced-950a-329ec93bc990",
                column: "ConcurrencyStamp",
                value: "2d48720c-4bad-4f04-8b03-73205a8f0f73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc2b02a4-65ae-47a6-86a9-a02a4e4b3836",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c2c6c69-1199-44af-bef8-14597dc2479c", "AQAAAAEAACcQAAAAEJGsOvEOU0uUJ7KTs7NVI347Cur/NdKaSg96qyVyT8JRBTeAnrRQ2FevlLTj1kwxtA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("73485868-82b5-4c0e-9d8d-5580fe9bfd55"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2020, 6, 25, 9, 3, 6, 377, DateTimeKind.Utc).AddTicks(6925), "Services" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("8b4ae5ff-d5da-417a-85f4-5c6ae24c8815"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2020, 6, 25, 9, 3, 6, 377, DateTimeKind.Utc).AddTicks(6843), "Contacts" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a7da92d3-495f-40b0-b986-4f0204ba6ea0"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2020, 6, 25, 9, 3, 6, 377, DateTimeKind.Utc).AddTicks(3994), "Home" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85011dea-56dd-4ced-950a-329ec93bc990",
                column: "ConcurrencyStamp",
                value: "59c3dc7e-2806-4d9e-b7b8-56210d53dcf2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc2b02a4-65ae-47a6-86a9-a02a4e4b3836",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0cc2df0-4f14-4932-a6d5-cef4ddb05026", "AQAAAAEAACcQAAAAECCB0hz1+ud4FPLq770NGPV5PkcEAba+jK37Xm1KBnmysJPY4SYEMRkM839w2F85zA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("73485868-82b5-4c0e-9d8d-5580fe9bfd55"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2020, 6, 23, 11, 54, 33, 942, DateTimeKind.Utc).AddTicks(4951), "Услуги" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("8b4ae5ff-d5da-417a-85f4-5c6ae24c8815"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2020, 6, 23, 11, 54, 33, 942, DateTimeKind.Utc).AddTicks(4828), "Контакты" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a7da92d3-495f-40b0-b986-4f0204ba6ea0"),
                columns: new[] { "DateAdded", "Title" },
                values: new object[] { new DateTime(2020, 6, 23, 11, 54, 33, 942, DateTimeKind.Utc).AddTicks(606), "Главная" });
        }
    }
}
