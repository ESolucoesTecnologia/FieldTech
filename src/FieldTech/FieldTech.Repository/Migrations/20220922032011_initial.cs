using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FieldTech.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Endereco = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Dt_Inclusao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Atualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

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
                name: "Ordem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Escopo = table.Column<string>(type: "ntext", nullable: false),
                    Projeto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Endereco = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Dt_Acionamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Agendamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Inclusao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Atualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    FornecedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ordem_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Logradouro = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
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
                    Ddd = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "OrdemDetalhe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Vl_Atividade = table.Column<double>(type: "float", nullable: false),
                    Qtd_Km = table.Column<double>(type: "float", nullable: false),
                    Vl_Km = table.Column<double>(type: "float", nullable: false),
                    Vl_Pedagio = table.Column<double>(type: "float", nullable: false),
                    Vl_Material = table.Column<double>(type: "float", nullable: false),
                    Vl_Hospedagem = table.Column<double>(type: "float", nullable: false),
                    Qtd_HoraExcedente = table.Column<double>(type: "float", nullable: false),
                    Vl_HoraExcedente = table.Column<double>(type: "float", nullable: false),
                    Dt_HoraInicioAtividade = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_HoraFimAtividade = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Inclusao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Atualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    OrdemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemDetalhe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemDetalhe_Ordem_OrdemId",
                        column: x => x.OrdemId,
                        principalTable: "Ordem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrdemDetalheTecnico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Vl_Atividade = table.Column<double>(type: "float", nullable: false),
                    Qtd_Km = table.Column<double>(type: "float", nullable: false),
                    Vl_Km = table.Column<double>(type: "float", nullable: false),
                    Vl_Pedagio = table.Column<double>(type: "float", nullable: false),
                    Vl_Material = table.Column<double>(type: "float", nullable: false),
                    Vl_Hospedagem = table.Column<double>(type: "float", nullable: false),
                    Qtd_HoraExcedente = table.Column<double>(type: "float", nullable: false),
                    Vl_HoraExcedente = table.Column<double>(type: "float", nullable: false),
                    Dt_HoraInicioAtividade = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_HoraFimAtividade = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Inclusao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dt_Atualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    TecnicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrdemDetalheId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemDetalheTecnico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemDetalheTecnico_OrdemDetalhe_OrdemDetalheId",
                        column: x => x.OrdemDetalheId,
                        principalTable: "OrdemDetalhe",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdemDetalheTecnico_Tecnico_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "Tecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Ordem_FornecedorId",
                table: "Ordem",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemDetalhe_OrdemId",
                table: "OrdemDetalhe",
                column: "OrdemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemDetalheTecnico_OrdemDetalheId",
                table: "OrdemDetalheTecnico",
                column: "OrdemDetalheId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemDetalheTecnico_TecnicoId",
                table: "OrdemDetalheTecnico",
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
                name: "OrdemDetalheTecnico");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "OrdemDetalhe");

            migrationBuilder.DropTable(
                name: "Tecnico");

            migrationBuilder.DropTable(
                name: "Ordem");

            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
