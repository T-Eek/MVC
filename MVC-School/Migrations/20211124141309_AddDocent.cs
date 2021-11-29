using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class AddDocent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_locaties",
                table: "locaties");

            migrationBuilder.RenameTable(
                name: "locaties",
                newName: "Locaties");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Studenten",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Locaties",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locaties",
                table: "Locaties",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Docent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Achternaam = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    LocatieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Docent_Locaties_LocatieId",
                        column: x => x.LocatieId,
                        principalTable: "Locaties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Docent_LocatieId",
                table: "Docent",
                column: "LocatieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locaties",
                table: "Locaties");

            migrationBuilder.RenameTable(
                name: "Locaties",
                newName: "locaties");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Studenten",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "locaties",
                newName: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_locaties",
                table: "locaties",
                column: "ID");
        }
    }
}
