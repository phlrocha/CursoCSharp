using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa(); // Pessoa = classe ou tipo da variável .. Pessoa() = construtor
            sicrano.Nome = "Pedro";
            sicrano.Idade = 26;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);

        }
    }
}
