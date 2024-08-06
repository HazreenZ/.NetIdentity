using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace authnetidentity.Migrations
{
    /// <inheritdoc />
    public partial class DoB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateofBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateofBirth",
                table: "AspNetUsers");
        }
    }
}
