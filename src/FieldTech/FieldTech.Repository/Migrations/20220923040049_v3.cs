using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FieldTech.Repository.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Tecnico_TecnicoId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_TecnicoId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "TecnicoId",
                table: "Endereco");

            migrationBuilder.AddColumn<Guid>(
                name: "EnderecoId",
                table: "Tecnico",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Tecnico_EnderecoId",
                table: "Tecnico",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tecnico_Endereco_EnderecoId",
                table: "Tecnico",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tecnico_Endereco_EnderecoId",
                table: "Tecnico");

            migrationBuilder.DropIndex(
                name: "IX_Tecnico_EnderecoId",
                table: "Tecnico");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Tecnico");

            migrationBuilder.AddColumn<Guid>(
                name: "TecnicoId",
                table: "Endereco",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_TecnicoId",
                table: "Endereco",
                column: "TecnicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Tecnico_TecnicoId",
                table: "Endereco",
                column: "TecnicoId",
                principalTable: "Tecnico",
                principalColumn: "Id");
        }
    }
}
