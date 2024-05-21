using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToManyDemo.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 1,
                column: "Titel",
                value: "Asp.Net");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 2,
                column: "Titel",
                value: "C# For beginer");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 3,
                column: "Titel",
                value: "SQL Server");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 4,
                column: "Titel",
                value: "EF Core");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 5,
                column: "Titel",
                value: "De wereld van .NET");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 6,
                column: "Titel",
                value: "De avonturen van Code 8");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 7,
                column: "Titel",
                value: "HTML");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 8,
                column: "Titel",
                value: "CSS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 1,
                column: "Titel",
                value: "De avonturen van Code 1");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 2,
                column: "Titel",
                value: "De avonturen van Code 2");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 3,
                column: "Titel",
                value: "De avonturen van Code 3");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 4,
                column: "Titel",
                value: "De avonturen van Code 4");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 5,
                column: "Titel",
                value: "De avonturen van Code 5");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 6,
                column: "Titel",
                value: "De avonturen van Code 6");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 7,
                column: "Titel",
                value: "De avonturen van Code 7");

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 8,
                column: "Titel",
                value: "De avonturen van Code 8");
        }
    }
}
