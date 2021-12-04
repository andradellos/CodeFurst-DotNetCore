using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyPushu.Data.Migrations
{
    public partial class InserirUserDefalt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Nome" },
                values: new object[] { new Guid("8dd9ac15-cd00-42d4-a3b8-eb9e20825a04"), "defalt@emai.com", "User Defalt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8dd9ac15-cd00-42d4-a3b8-eb9e20825a04"));
        }
    }
}
