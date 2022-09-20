using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FieldTech.Repository.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tecnico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dt_Nascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    CpfCnpj = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Rg = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    OrgaoEmissor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    EstadoCivil = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Dt_Inclusao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Atualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_Inclusao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Atualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    TecnicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Email_Tecnico_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "Tecnico",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_Inclusao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Atualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    TecnicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Tecnico_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "Tecnico",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ddd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_Inclusao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Atualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    TecnicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefone_Tecnico_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "Tecnico",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Email_TecnicoId",
                table: "Email",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_TecnicoId",
                table: "Endereco",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_TecnicoId",
                table: "Telefone",
                column: "TecnicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Tecnico");
        }
    }
}
