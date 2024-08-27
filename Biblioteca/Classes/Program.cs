using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    class Program
    {
        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();

            Livro livro = new Livro("C# Avançado", 2022, "Autor Desconhecido");
            Revista revista = new Revista ("Revista Tecnologia", 2024, 45, "Março");
            Jornal jornal = new Jornal("Jornal Diário", 2024, DateTime.Now);

            biblioteca.AdicionarItem(livro);
            biblioteca.AdicionarItem(revista);
            biblioteca.AdicionarItem(jornal);

            Usuario usuario = new Usuario ("João Silva", 123);
            biblioteca.RegistroUsuario(usuario);
            usuario.EmprestarItem(livro);
            usuario.EmprestarItem(revista);

            biblioteca.ListarItensDisponiveis();
            biblioteca.ListarItensEmprestados();

            usuario.DevolverItem(livro);
            biblioteca.ListarItensDisponiveis();

        }
    }
}
