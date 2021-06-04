using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Game";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine($"O {nome} da marca {marca} custa R$ {preco}");

            // dentro da interpolação é possivel realizar operações ex: {1 + 1 }
        }
    }
}
