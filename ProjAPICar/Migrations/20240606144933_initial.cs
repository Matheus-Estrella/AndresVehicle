using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjAPICar.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    _licensePlate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    _name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _modelYear = table.Column<int>(type: "int", nullable: false),
                    _makedYear = table.Column<int>(type: "int", nullable: false),
                    _color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x._licensePlate);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
