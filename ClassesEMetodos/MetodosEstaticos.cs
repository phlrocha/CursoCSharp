﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        //Metodo de instancia 
        public int Somar(int a, int b)
        {
            return a + b;
        }

        // Metodo de classe ou metodo estático
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine($"Resultado = {resultado}");

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));


        }
    }
}
