using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area de circunferencia
            double raio = 4.5;
            const double pi = 3.14;
            double area = pi * raio * raio;
            Console.WriteLine($" O tamanho da área da circunferencia é de {area}");

            // tipos internos

            bool estaChovendo = true;
            Console.WriteLine($"Está chovendo? {estaChovendo}");

            byte idade = 45;
            Console.WriteLine($"Idade = {idade} anos");

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine($"Saldo de gols = {saldoDeGols}");

            short salario = short.MaxValue;
            Console.WriteLine($"Salário = R$ {salario}");

            int menorValorInt = int.MinValue;
            Console.WriteLine($"Menor Valor = {menorValorInt}");

            uint populacaoBrasileira = 207_600_000; //UINT = INT sem sinal
            Console.WriteLine($"População Brasileira = {populacaoBrasileira}");

            long menorValorLong = long.MinValue;
            Console.WriteLine($"Menor valor long = {menorValorLong}");

            ulong populacaoMundial = 7_600_000_000; //ulong = long sem o sinal 
            Console.WriteLine($"População mundial = {populacaoMundial}");

            float precoComputador = 1299.99f;
            Console.WriteLine($"Preço do compuador =R$ {precoComputador}");

            double valorDeMercadoDaApple = 1_000_000_000.00;
            Console.WriteLine($"Valor de mercado da Apple = {valorDeMercadoDaApple}");

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine($"Distancia entre estrelas = {distanciaEntreEstrelas}");

            char letra = 'b';
            Console.WriteLine($"Letra = {letra}");

            string texto = "Seja Bem Vindo ao curso de C#";
            Console.WriteLine($"Texto = {texto}");

        }
    }
}
