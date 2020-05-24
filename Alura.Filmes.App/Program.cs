using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //select * from actor
            using (var contexto = new AluraFilmesContexto())
            {

                var filme = contexto.Filmes
                    .Include(f => f.Atores)
                    .First();
                Console.WriteLine(filme);
                Console.WriteLine("Elenco: ");
                foreach (var ator in filme.Atores)
                {
                    Console.WriteLine(ator);
                }
            }
            Console.ReadKey();
        }
    }
}