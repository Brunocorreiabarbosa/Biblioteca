using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int NumeroDeRegistro { get; set; }

        public Usuario (string nome, int numeroDeRegistro)
        {
            Nome = nome;
            NumeroDeRegistro = numeroDeRegistro;
        }
        public void EmprestarItem(ItemBiblioteca item)
        {
            if (item.Disponivel)
            {
                item.Emprestar();
            }
            else
            {
                Console.WriteLine($"Item '{item.Titulo}' não está disponivel para emprestimo.");
            }
        }
        public void DevolverItem( ItemBiblioteca item)
        {
            if (!item.Disponivel)
            {
                item.Devolver();
            }
            else
            {
                Console.WriteLine($"Item '{item.Titulo} não esta emprestado");
            }
        }
    }
}
