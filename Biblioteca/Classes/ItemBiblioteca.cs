using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public abstract class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public bool Disponivel { get; set; } = true;

        public ItemBiblioteca(string titulo, int anoPublicacao)
        {
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
        }
    }
}
