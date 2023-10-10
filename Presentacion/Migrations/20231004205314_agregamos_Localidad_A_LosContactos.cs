using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentacion.Migrations
{
    /// <inheritdoc />
    public partial class agregamos_Localidad_A_LosContactos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalidadId",
                table: "Contactos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_LocalidadId",
                table: "Contactos",
                column: "LocalidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contactos_Localidades_LocalidadId",
                table: "Contactos",
                column: "LocalidadId",
                principalTable: "Localidades",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contactos_Localidades_LocalidadId",
                table: "Contactos");

            migrationBuilder.DropIndex(
                name: "IX_Contactos_LocalidadId",
                table: "Contactos");

            migrationBuilder.DropColumn(
                name: "LocalidadId",
                table: "Contactos");
        }
    }
}
