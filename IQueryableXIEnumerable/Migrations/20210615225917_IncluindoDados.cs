using Microsoft.EntityFrameworkCore.Migrations;

namespace IQueryableXIEnumerable.Migrations
{
    public partial class IncluindoDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "AlunoId", "Idade", "Nome" },
                values: new object[] { 1, 48, "Humberto" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "AlunoId", "Idade", "Nome" },
                values: new object[] { 2, 9, "Gabriel de Souza" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "AlunoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "AlunoId",
                keyValue: 2);
        }
    }
}
