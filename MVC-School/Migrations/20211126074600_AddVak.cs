using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class AddVak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docent_Locaties_LocatieId",
                table: "Docent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locaties",
                table: "Locaties");

            migrationBuilder.RenameTable(
                name: "Locaties",
                newName: "Locatie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locatie",
                table: "Locatie",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Vak",
                columns: table => new
                {
                    VakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VakNaam = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DocentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vak", x => x.VakId);
                    table.ForeignKey(
                        name: "FK_Vak_Docent_DocentId",
                        column: x => x.DocentId,
                        principalTable: "Docent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vak_DocentId",
                table: "Vak",
                column: "DocentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Docent_Locatie_LocatieId",
                table: "Docent",
                column: "LocatieId",
                principalTable: "Locatie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docent_Locatie_LocatieId",
                table: "Docent");

            migrationBuilder.DropTable(
                name: "Vak");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locatie",
                table: "Locatie");

            migrationBuilder.RenameTable(
                name: "Locatie",
                newName: "Locaties");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locaties",
                table: "Locaties",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Docent_Locaties_LocatieId",
                table: "Docent",
                column: "LocatieId",
                principalTable: "Locaties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
