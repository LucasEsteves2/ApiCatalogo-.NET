using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatlogo.Migrations
{
    /// <inheritdoc />
    public partial class _123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_x_Categoria_CategoriaId",
                table: "x");

            migrationBuilder.DropPrimaryKey(
                name: "PK_x",
                table: "x");

            migrationBuilder.RenameTable(
                name: "x",
                newName: "Produtos");

            migrationBuilder.RenameIndex(
                name: "IX_x_CategoriaId",
                table: "Produtos",
                newName: "IX_Produtos_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categoria_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categoria_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "x");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_CategoriaId",
                table: "x",
                newName: "IX_x_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_x",
                table: "x",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_x_Categoria_CategoriaId",
                table: "x",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id");
        }
    }
}
