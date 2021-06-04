using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {

            var ExecutouTrabalho1 = true;
            var ExecutouTrabalho2 = false;

            bool comprouTV50 = ExecutouTrabalho1 && ExecutouTrabalho2;
            Console.WriteLine($"Comprou a TV 50? {comprouTV50}");

            var comprouSorvete = ExecutouTrabalho1 || ExecutouTrabalho2;
            Console.WriteLine($"Comprou sorteve? {comprouSorvete}");

            var comprouTV32 = ExecutouTrabalho1 ^ ExecutouTrabalho2;
            Console.WriteLine($"Comprou a TV 32? {comprouTV32}");

            Console.WriteLine($"Mais saudável? {!comprouSorvete}");

        }
    }
}
