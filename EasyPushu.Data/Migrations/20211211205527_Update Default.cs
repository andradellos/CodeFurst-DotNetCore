using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyPushu.Data.Migrations
{
    public partial class UpdateDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8dd9ac15-cd00-42d4-a3b8-eb9e20825a04"),
                column: "DateCreated",
                value: new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8dd9ac15-cd00-42d4-a3b8-eb9e20825a04"),
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
