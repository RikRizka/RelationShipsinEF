using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToManyDemo.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoekenViewModel",
                columns: table => new
                {
                    GeselecteerdeAuteurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 1,
                column: "Naam",
                value: "Alain CHarlier");

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 2,
                column: "Naam",
                value: "Rick Rizka");

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 3,
                column: "Naam",
                value: "Deny Pratama");

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 4,
                column: "Naam",
                value: "David vander vaken");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoekenViewModel");

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 1,
                column: "Naam",
                value: "J.K. Rowling");

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 2,
                column: "Naam",
                value: "Stephen King");

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 3,
                column: "Naam",
                value: "J.R.R. Tolkien");

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 4,
                column: "Naam",
                value: "Dan Brown");
        }
    }
}
