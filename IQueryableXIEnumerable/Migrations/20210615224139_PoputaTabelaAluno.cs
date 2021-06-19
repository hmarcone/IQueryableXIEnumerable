using Microsoft.EntityFrameworkCore.Migrations;

namespace IQueryableXIEnumerable.Migrations
{
    public partial class PoputaTabelaAluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Alunos (Nome, Idade) Values ('Maria', 22)");
            migrationBuilder.Sql("Insert Into Alunos (Nome, Idade) Values ('Pedro', 19)");
            migrationBuilder.Sql("Insert Into Alunos (Nome, Idade) Values ('João', 24)");
            migrationBuilder.Sql("Insert Into Alunos (Nome, Idade) Values ('José', 25)");
            migrationBuilder.Sql("Insert Into Alunos (Nome, Idade) Values ('Antônio Rodrigues', 21)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From Alunos");
        }
    }
}
