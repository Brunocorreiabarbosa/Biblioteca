using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Livro : ItemBiblioteca,IEmprestimo
    {
        public string Autor { get; set; }

        public Livro(string titulo, int anoPublicacao, string autor)
            : base(titulo, anoPublicacao)
        {
            Autor = autor;
        }
        public void Emprestar()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine($"Livro: '{Titulo}' emprestado.");
            }
            else
            {
                Console.WriteLine($"Livro: '{Titulo}' não esta disponivel");
            }
        }
        public void Devolver()
        {
            Disponivel = true;
            Console.WriteLine($"Livros: '{Titulo}' devolvido");
        }
    }
}
