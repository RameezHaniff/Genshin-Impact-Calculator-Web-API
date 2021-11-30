using Microsoft.EntityFrameworkCore.Migrations;

namespace GenshinWebApp.Migrations
{
    public partial class DamageType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("DamageType","ability_scaling", "varchar(255)",
                unicode: false, maxLength: 255, nullable: true);
        }
    }
}
