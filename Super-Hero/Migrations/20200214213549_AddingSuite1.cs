using Microsoft.EntityFrameworkCore.Migrations;

namespace Super_Hero.Migrations
{
    public partial class AddingSuite1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuitNumber = table.Column<string>(nullable: true),
                    SuitName = table.Column<string>(nullable: true),
                    Specialty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suits", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suits");
        }
    }
}
