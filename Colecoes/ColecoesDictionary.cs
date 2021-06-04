using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>(); // Dictionary < chave, valor> chave nao aceita repetição, valor aceita

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");


        foreach(var filme in filmes)
            {
                Console.WriteLine($"O filme {filme.Value} é de {filme.Key}");
            }
        }
    }
}
