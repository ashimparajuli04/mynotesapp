using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace notes.Migrations
{
    /// <inheritdoc />
    public partial class removecreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Note");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Note",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Note",
                type: "TEXT",
                nullable: true);
        }
    }
}
