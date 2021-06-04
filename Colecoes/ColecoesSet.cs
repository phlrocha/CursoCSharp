using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{ 

   class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>(); //HashSet é uma estrutura nao indexada que nao aceita repetição
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            { new Produto("Camisa", 29.9),
              new Produto("8a Temp Game of Thrones", 99.9),
              new Produto("Poster",10),
              new Produto("Poster",10)

            };

            carrinho.UnionWith(combo); 
            Console.WriteLine(carrinho.Count);
          // carrinho.RemoveAt(3); // remover 

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }


        }
    }
}
