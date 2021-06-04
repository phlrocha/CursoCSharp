﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar ()
        {

            //preço desconto

            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine($"O preço final é {totalComDesconto}");


            //IMC

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine(imc);


        }
    }
}
