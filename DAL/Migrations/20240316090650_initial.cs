using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupPermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupPermission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "CreatedDateTime", "Name", "UpdatedDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(5077), "Administrator", null },
                    { 2, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(5082), "SuperUser", null },
                    { 3, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(5085), "User", null }
                });

            migrationBuilder.InsertData(
                table: "GroupPermission",
                columns: new[] { "Id", "CreatedDateTime", "GroupId", "PermissionId", "UpdatedDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 16, 11, 6, 44, 181, DateTimeKind.Local).AddTicks(29), 1, 1, null },
                    { 2, new DateTime(2024, 3, 16, 11, 6, 44, 181, DateTimeKind.Local).AddTicks(33), 1, 2, null },
                    { 3, new DateTime(2024, 3, 16, 11, 6, 44, 181, DateTimeKind.Local).AddTicks(56), 1, 3, null },
                    { 4, new DateTime(2024, 3, 16, 11, 6, 44, 181, DateTimeKind.Local).AddTicks(59), 2, 2, null },
                    { 5, new DateTime(2024, 3, 16, 11, 6, 44, 181, DateTimeKind.Local).AddTicks(62), 2, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreatedDateTime", "Name", "UpdatedDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(6374), "Admin", null },
                    { 2, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(6378), "SuperUser", null },
                    { 3, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(6381), "User", null },
                    { 4, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(6383), "Restricted", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Approved", "CreatedDateTime", "Email", "FirstName", "LastName", "Password", "UpdatedDateTime" },
                values: new object[] { 1, true, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(3483), "admin@admin.com", "Admin", "Admin", "admin", null });

            migrationBuilder.InsertData(
                table: "UserGroup",
                columns: new[] { "Id", "CreatedDateTime", "GroupId", "UpdatedDateTime", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(7813), 1, null, 1 },
                    { 2, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(7817), 2, null, 1 },
                    { 3, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(7820), 3, null, 1 },
                    { 4, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(7822), 2, null, 2 },
                    { 5, new DateTime(2024, 3, 16, 11, 6, 44, 180, DateTimeKind.Local).AddTicks(7825), 3, null, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "GroupPermission");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserGroup");
        }
    }
}
