using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamercante.Migrations
{
    public partial class Game : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Game",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Plataforma",
                table: "Game",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plataforma",
                table: "Game");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Img",
                table: "Game",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
