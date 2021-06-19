using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IQueryableXIEnumerable
{
    public class AppDbContext: DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
              : base(options)
        { }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projetos;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {              
                    AlunoId = 1,
                    Nome = "Humberto",
                    Idade = 48
                },
                new Aluno
                {
                    AlunoId = 2,
                    Nome = "Gabriel de Souza",
                    Idade = 9
                }
            );
        }
    }
}
