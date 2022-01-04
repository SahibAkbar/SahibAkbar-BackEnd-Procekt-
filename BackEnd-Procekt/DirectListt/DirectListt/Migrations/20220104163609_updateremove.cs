using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectListt.Migrations
{
    public partial class updateremove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "AspNetUsers",
                type: "nvarchar(3000)",
                maxLength: 3000,
                nullable: true);
        }
    }
}
