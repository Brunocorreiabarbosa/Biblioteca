using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Revista : ItemBiblioteca, IEmprestimo
    {
        public int NumeroEdicao { get; set; }
        public string MesPublicacao { get; set; }

        public Revista(string titulo, int anoPublicacao, int numeroEdicao, string mesPublicacao)
            : base (titulo, anoPublicacao)
        {
            NumeroEdicao = numeroEdicao;
            MesPublicacao = mesPublicacao;
        }
        public void Emprestar()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine($"Revista '{Titulo}' emprestada.");
            }
            else
            {
                Console.WriteLine($"Reviata '{Titulo}' não está disponivel");
            }
        }
        public void Devolver()
        {
            Disponivel = true;
            Console.WriteLine($"Revista '{Titulo}' devolvida");
        }
    }
}
