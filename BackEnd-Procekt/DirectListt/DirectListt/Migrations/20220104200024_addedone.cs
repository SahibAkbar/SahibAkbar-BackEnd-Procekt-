using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectListt.Migrations
{
    public partial class addedone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "RestaurantReviews",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "CretedDate",
                table: "RestaurantReviews",
                newName: "CreatedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "RestaurantReviews",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "RestaurantReviews",
                newName: "CretedDate");
        }
    }
}
