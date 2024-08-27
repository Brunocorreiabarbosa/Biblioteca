using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Biblioteca
    {
        private List<ItemBiblioteca> itensBiblioteca = new List<ItemBiblioteca>();
        private List<Usuario> usuarios = new List<Usuario>();

        public void AdicionarItem(ItemBiblioteca item)
        {
            itensBiblioteca.Add(item);
            Console.WriteLine($"Item '{item.Titulo}' adicionado a biblioteca");
        }
        public void RemoverItem(ItemBiblioteca item)
        {
            if (itensBiblioteca.Contains(item))
            {
                itensBiblioteca.Remove(item);
                Console.WriteLine($"Item '{item.Titulo}' removido da biblioteca.");
            }
            else
            {
                Console.WriteLine($"Item '{item.Titulo}' não foi encontrado");
            }
        }
        public void ListarItensDisponiveis()
        {
            Console.WriteLine("Itens Disponiveis:");
            foreach (var item in itensBiblioteca)
            {
                if (item.Disponivel)
                {
                    Console.WriteLine($" - {item.Titulo}");
                }
            }
        }
        public void ListarItensEmprestados()
        {
            Console.WriteLine("Itens emprestados:");
            foreach( var item in itensBiblioteca)
            {
                if (!item.Disponivel)
                {
                    Console.WriteLine($"- {item.Titulo}");
                }
            }
        }
        public void RegistroUsuario(Usuario usuario)
        {
            if (usuarios.Contains(usuario))
            {
                usuarios.Remove(usuario);
                Console.WriteLine($"Usuario '{usuario.Nome}' removido.");
            }
            else
            {
                Console.WriteLine($"Usuario '{usuario.Nome}' não encontrado");
            }
            
        }
        
    }
}
