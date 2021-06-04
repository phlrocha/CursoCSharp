using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {

            var p1 = new Produto("Caneta",1.89);         // a class Produto é em ColecoesList
            var p2 = new Produto("Caneta",1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2); // apontam para locais de memória diferentes
            Console.WriteLine(p3 == p2); // apontam para o mesmo local de memoria, pois p3 = p2

            Console.WriteLine(p1.Equals(p2));

        }

    }
}
