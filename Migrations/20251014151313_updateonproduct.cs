using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisonTelecomInventory.Migrations
{
    /// <inheritdoc />
    public partial class updateonproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
