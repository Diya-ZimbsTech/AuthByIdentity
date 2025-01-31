using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthByIdentity.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18050b02-4c79-4d56-9e6a-20a64701f239", null, "client", "client" },
                    { "1c3d10d6-1d38-4f0e-84b7-37ae1f4276aa", null, "admin", "admin" },
                    { "c4dcfb79-5aef-4f78-a592-d6a33c00610f", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18050b02-4c79-4d56-9e6a-20a64701f239");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c3d10d6-1d38-4f0e-84b7-37ae1f4276aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4dcfb79-5aef-4f78-a592-d6a33c00610f");
        }
    }
}
