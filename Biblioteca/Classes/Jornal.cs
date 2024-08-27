using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Jornal : ItemBiblioteca, IEmprestimo
    {
        public DateTime DataPublicacao { get; set; }

        public Jornal(string titulo,int anoPublicacao,DateTime dataPublicacao)
            : base (titulo, anoPublicacao)
        {
            DataPublicacao = dataPublicacao;
        }
        public void Emprestar()
        {
            if (Disponivel){
                Disponivel = false;
                Console.WriteLine($"Jornal '{Titulo}' emprestado");
            }
            else
            {
                Console.WriteLine($"Jornal '{Titulo}' não está disponivel");
            }
        }
        public void Devolver()
        {
            Disponivel = true;
            Console.WriteLine($"Jornal '{Titulo}' Devolvido");
        }
    }
}
