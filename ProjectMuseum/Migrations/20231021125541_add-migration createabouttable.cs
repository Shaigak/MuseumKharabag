using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMuseum.Migrations
{
    public partial class addmigrationcreateabouttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "Blogs");
        }
    }
}
