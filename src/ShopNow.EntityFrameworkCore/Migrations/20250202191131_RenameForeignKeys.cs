using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopNow.Migrations
{
    /// <inheritdoc />
    public partial class RenameForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubCatId",
                schema: "product",
                table: "ProductsTbl");

            migrationBuilder.DropColumn(
                name: "SubSubCatId",
                schema: "product",
                table: "ProductsTbl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SubCatId",
                schema: "product",
                table: "ProductsTbl",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SubSubCatId",
                schema: "product",
                table: "ProductsTbl",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
