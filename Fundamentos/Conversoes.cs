using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine($"Nota Truncada = {notaTruncada}");

            string idadeString = "20";
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade = {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado {idadeInteiro}" );

            Console.WriteLine("Digite o primeiro numero" );
            int.TryParse(Console.ReadLine(), out int numero);
            Console.WriteLine($"Resultado : {numero}");


        }
    }
}
