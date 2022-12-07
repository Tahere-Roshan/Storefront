using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Storefront.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceforTour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Tours",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Tours");
        }
    }
}
