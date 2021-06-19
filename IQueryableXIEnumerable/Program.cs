using System;
using System.Collections.Generic;
using System.Linq;

namespace IQueryableXIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var _context = new AppDbContext())
            {
                //IEnumerable<Aluno> alunos = _context.Alunos;
                IQueryable<Aluno> alunos = _context.Alunos; //já trás do banco somente od registros de acordo com o filtro idade > 21
                IEnumerable<Aluno> resultado = alunos.Where(a => a.Idade > 21).ToList();

                foreach (var aluno in resultado)
                {
                    Console.WriteLine($"{aluno.Nome} {aluno.Idade}");
                }

                Console.ReadLine();
            }
        }
    }
}
