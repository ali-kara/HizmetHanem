using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menus_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    MenuItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.MenuItemId);
                    table.ForeignKey(
                        name: "FK_MenuItem_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItem_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "DateCreated", "DateModified", "IsDeleted", "LastUser" },
                values: new object[,]
                {
                    { 1, "Yiyecekler", new DateTime(2022, 3, 10, 12, 53, 42, 440, DateTimeKind.Local).AddTicks(6220), null, false, null },
                    { 2, "İçecekler", new DateTime(2022, 3, 10, 12, 53, 42, 441, DateTimeKind.Local).AddTicks(6967), null, false, null },
                    { 3, "Sütlü Tatlılar", new DateTime(2022, 3, 10, 12, 53, 42, 441, DateTimeKind.Local).AddTicks(6985), null, false, null },
                    { 4, "Soğuk Tatlılar", new DateTime(2022, 3, 10, 12, 53, 42, 441, DateTimeKind.Local).AddTicks(6988), null, false, null },
                    { 5, "Meyveler", new DateTime(2022, 3, 10, 12, 53, 42, 441, DateTimeKind.Local).AddTicks(6990), null, false, null },
                    { 6, "Ara Sıcaklar", new DateTime(2022, 3, 10, 12, 53, 42, 441, DateTimeKind.Local).AddTicks(6991), null, false, null }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "DateCreated", "DateModified", "IsDeleted", "LastUser", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 10, 12, 53, 42, 442, DateTimeKind.Local).AddTicks(8236), null, false, null, "Peters PLC" },
                    { 2, new DateTime(2022, 3, 10, 12, 53, 42, 443, DateTimeKind.Local).AddTicks(8521), null, false, null, "Haines Group" },
                    { 3, new DateTime(2022, 3, 10, 12, 53, 42, 443, DateTimeKind.Local).AddTicks(8546), null, false, null, "Whitehouse and Partners" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "CompanyId", "Name" },
                values: new object[] { 1, 1, "Menu 1" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "CompanyId", "Name" },
                values: new object[] { 2, 2, "Menu 2" });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "MenuItemId", "CategoryId", "DateCreated", "DateModified", "Description", "ImageLink", "IsDeleted", "ItemName", "LastUser", "MenuId", "Price" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 10, 12, 53, 42, 444, DateTimeKind.Local).AddTicks(786), null, "Sed adipiscing dolor eget turpis eleifend eleifend. Nullam et enim congue, pretium eros id, pretium nibh. Nullam et enim congue, pretium eros id, pretium nibh.", null, false, "Whitehouse", null, 1, 40.0 });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "MenuItemId", "CategoryId", "DateCreated", "DateModified", "Description", "ImageLink", "IsDeleted", "ItemName", "LastUser", "MenuId", "Price" },
                values: new object[] { 2, 3, new DateTime(2022, 3, 10, 12, 53, 42, 445, DateTimeKind.Local).AddTicks(8449), null, "Duis gravida erat et euismod consequat. In laoreet justo et condimentum bibendum. Phasellus pharetra leo eu tempor molestie.", null, false, "Fleming", null, 2, 23.399999999999999 });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "MenuItemId", "CategoryId", "DateCreated", "DateModified", "Description", "ImageLink", "IsDeleted", "ItemName", "LastUser", "MenuId", "Price" },
                values: new object[] { 3, 3, new DateTime(2022, 3, 10, 12, 53, 42, 445, DateTimeKind.Local).AddTicks(8632), null, "Vivamus porta neque non neque malesuada scelerisque. Vivamus scelerisque felis sed nisl feugiat, mattis consequat lacus pulvinar. Nullam quis turpis eu urna vehicula ornare vel et enim.", null, false, "Hilton", null, 2, 54.0 });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_CategoryId",
                table: "MenuItem",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_MenuId",
                table: "MenuItem",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_CompanyId",
                table: "Menus",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
