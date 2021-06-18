using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            ///action é sempre uma void, ou seja, não tem retorno
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            algoNoConsole();

            Func<int> jogarDado = () => // Func<parametro,parametro, retorno> o ultimo parametro é o retorno
            {
                Random dice = new Random();
                return dice.Next(1, 7);
                
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            // usando ' => ' diretamente, sem chaves, e com um unico parametro na 
            // função, o "return" está implicito em " numero.ToString("X") "
            Console.WriteLine(conversorHex(1994));


        }
    }
}
