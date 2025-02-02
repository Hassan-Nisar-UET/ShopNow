using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopNow.Migrations
{
    /// <inheritdoc />
    public partial class migrationOfsixtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Category");

            migrationBuilder.EnsureSchema(
                name: "Dimention");

            migrationBuilder.EnsureSchema(
                name: "product");

            migrationBuilder.EnsureSchema(
                name: "Store");

            migrationBuilder.EnsureSchema(
                name: "SubCategory");

            migrationBuilder.EnsureSchema(
                name: "SubSubCategory");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dimentions",
                schema: "Dimention",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimentions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                schema: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubSubCategories",
                schema: "SubSubCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubSubCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsTbl",
                schema: "product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DimentionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubCatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubSubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubSubCatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsTbl_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "Category",
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductsTbl_Dimentions_DimentionId",
                        column: x => x.DimentionId,
                        principalSchema: "Dimention",
                        principalTable: "Dimentions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductsTbl_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalSchema: "SubCategory",
                        principalTable: "SubCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductsTbl_SubSubCategories_SubSubCategoryId",
                        column: x => x.SubSubCategoryId,
                        principalSchema: "SubSubCategory",
                        principalTable: "SubSubCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductsTbl_stores_StoreId",
                        column: x => x.StoreId,
                        principalSchema: "Store",
                        principalTable: "stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsTbl_CategoryId",
                schema: "product",
                table: "ProductsTbl",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsTbl_DimentionId",
                schema: "product",
                table: "ProductsTbl",
                column: "DimentionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsTbl_StoreId",
                schema: "product",
                table: "ProductsTbl",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsTbl_SubCategoryId",
                schema: "product",
                table: "ProductsTbl",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsTbl_SubSubCategoryId",
                schema: "product",
                table: "ProductsTbl",
                column: "SubSubCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsTbl",
                schema: "product");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "Category");

            migrationBuilder.DropTable(
                name: "Dimentions",
                schema: "Dimention");

            migrationBuilder.DropTable(
                name: "SubCategories",
                schema: "SubCategory");

            migrationBuilder.DropTable(
                name: "SubSubCategories",
                schema: "SubSubCategory");

            migrationBuilder.DropTable(
                name: "stores",
                schema: "Store");
        }
    }
}
