using Microsoft.EntityFrameworkCore.Migrations;

namespace GenshinWebApp.Migrations
{
    public partial class NewColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Scaling",
                table: "ability_scaling_value",
                newName: "scaling");

            migrationBuilder.RenameColumn(
                name: "ScalingId",
                table: "ability_scaling_value",
                newName: "scaling_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "scaling",
                table: "ability_scaling_value",
                newName: "Scaling");

            migrationBuilder.RenameColumn(
                name: "scaling_id",
                table: "ability_scaling_value",
                newName: "ScalingId");
        }
    }
}
