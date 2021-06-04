using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 1) // valores padrão
        {
            return a + b;
        }

        public static void Executar()
        {
            Console.WriteLine(Somar(10,23)); // 10 + 23 
            Console.WriteLine(Somar(50)); // 50 + 1 b com valor padrao
            Console.WriteLine(Somar()); // 1 + 1 valores padrao
            Console.WriteLine(Somar(b:7)); // 1 + 7 parametro nomeado

        }
    }
}
