using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
       public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // F1 o numero que acompanha F é o numero de casas decimais - também é valido colocar(" #.#), as # depois do ponto são as casas decimais
            Console.WriteLine(valor.ToString("C")); // C  - para transformar em um valor monetário
            Console.WriteLine(valor.ToString("P")); //P - converte em % e multiplica por 100


            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // completa o numero em questão para ficar com X posições ( o numero que acompanha D define)

        
        }
    }
}
