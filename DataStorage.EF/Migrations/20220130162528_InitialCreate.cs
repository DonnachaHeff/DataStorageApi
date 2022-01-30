using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataStorage.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpectedObjects",
                columns: table => new
                {
                    ObjectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Repository = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpectedObjects", x => x.ObjectId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpectedObjects");
        }
    }
}
