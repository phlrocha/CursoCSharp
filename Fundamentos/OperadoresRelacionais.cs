using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;

            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota invalida? {nota > 10.0}");
            Console.WriteLine($"Nota invalida? {nota < 0.0}");
            Console.WriteLine($"Perfeito? {nota == 10.0}");
            Console.WriteLine($"Aprovado? {nota >= notaDeCorte}");
            Console.WriteLine($"Reprovado?{nota <= 10}");
                
        }
    }
}
