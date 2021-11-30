using GenshinWebApp.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GenshinWebApp.Migrations
{
    public partial class NewScaling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DamageType",
                table: "ability_scaling",
                newName: "damage_type");

            migrationBuilder.CreateTable(
                name: "ability_scaling_value",
                columns: table => new
                {
                    ScalingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Scaling = table.Column<Scaling>(type: "jsonb", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ability_scaling_value", x => x.ScalingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ability_scaling_value");

            migrationBuilder.RenameColumn(
                name: "damage_type",
                table: "ability_scaling",
                newName: "DamageType");
        }
    }
}
