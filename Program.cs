using Aula36MVCConsole.Controllers;

namespace Aula36MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController produto = new ProdutoController();
           produto.Filtrar("7500");
        }
    }
}
