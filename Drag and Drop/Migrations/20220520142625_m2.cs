using Microsoft.EntityFrameworkCore.Migrations;

namespace Drag_and_Drop.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pateintType",
                table: "Add_Pateint",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pateintType",
                table: "Add_Pateint");
        }
    }
}
