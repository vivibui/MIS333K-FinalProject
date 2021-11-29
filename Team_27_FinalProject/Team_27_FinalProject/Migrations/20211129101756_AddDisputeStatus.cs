using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_27_FinalProject.Migrations
{
    public partial class AddDisputeStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DStatus",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DStatus",
                table: "Reviews");
        }
    }
}
