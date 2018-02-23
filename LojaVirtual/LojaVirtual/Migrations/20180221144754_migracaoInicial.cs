using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LojaVirtual.Migrations
{
    public partial class migracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategoria",
                columns: table => new
                {
                    SubCategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 1200, nullable: true),
                    Imagem = table.Column<string>(maxLength: 200, nullable: true),
                    ImagemThumbnail = table.Column<string>(maxLength: 200, nullable: true),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    Visivel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoria", x => x.SubCategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 1200, nullable: true),
                    Imagem = table.Column<string>(maxLength: 200, nullable: true),
                    ImagemThumbnail = table.Column<string>(maxLength: 200, nullable: true),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    SubCategoriaId = table.Column<int>(nullable: true),
                    Visivel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                    table.ForeignKey(
                        name: "FK_Categoria_SubCategoria_SubCategoriaId",
                        column: x => x.SubCategoriaId,
                        principalTable: "SubCategoria",
                        principalColumn: "SubCategoriaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: true),
                    Descricao = table.Column<string>(maxLength: 1200, nullable: true),
                    Imagem = table.Column<string>(maxLength: 200, nullable: true),
                    ImagemThumbnail = table.Column<string>(maxLength: 200, nullable: true),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    Visivel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.DepartamentoId);
                    table.ForeignKey(
                        name: "FK_Departamento_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_SubCategoriaId",
                table: "Categoria",
                column: "SubCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_CategoriaId",
                table: "Departamento",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "SubCategoria");
        }
    }
}
