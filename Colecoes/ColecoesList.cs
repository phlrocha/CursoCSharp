using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco);
        }




    }


        class ColecoesList
        {
            public static void Executar()
            {
                var livro = new Produto("Game of Thrones", 49.9);

                var carrinho = new List<Produto>(); // List é uma estrutura dinamica, ou seja sem tamanho definido
                carrinho.Add(livro);

                var combo = new List<Produto>
            { new Produto("Camisa", 29.9),
              new Produto("8a Temp Game of Thrones", 99.9),
              new Produto("Poster",10),
              
            };

                carrinho.AddRange(combo); // AddRange = adicionar varios items de uma vez
                Console.WriteLine(carrinho.Count);
                carrinho.RemoveAt(3); // remover 

                foreach (var item in carrinho)
                {
                    Console.Write(carrinho.IndexOf(item));
                    Console.WriteLine($" {item.Nome} {item.Preco}");
                }


            }
        }

    
}