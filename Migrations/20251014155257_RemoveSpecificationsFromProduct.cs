using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisonTelecomInventory.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSpecificationsFromProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specifications",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Specifications",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
