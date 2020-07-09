using System;
using System.Collections.Generic;
using Aula36MVCConsole.Models;

namespace Aula36MVCConsole.Views
{
    public class ProdutoView
    {
        
     public void MostrarNoConsole(List<Produto> lista)
     {
      foreach (Produto item in lista)
     {
         Console.WriteLine($"R$ {item.Codigo} - {item.Preco} - {item.Nome} ");
      }

     }

    }
}