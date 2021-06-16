using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO
{

    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho); // recebido por herança mesmo de projetos diferentes
            //Console.WriteLine(NumeroCelular); sem acesso por nao ser do mesmo projeto (assembly)
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia); somente mesmo projeto
            //Console.WriteLine(UsoMuitoPhotoshop); objeto privado
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();
        public void MeusAcessos()
        {
            Console.WriteLine("AmigoDistante...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); // recebido por herança mesmo de projetos diferentes
            //Console.WriteLine(amiga.NumeroCelular); sem acesso por nao ser do mesmo projeto (assembly)
            //Console.WriteLine(amiga.JeitoDeFalar); // somente herança ou mesmo projeto
            //Console.WriteLine(amiga.SegredoFamilia); somente mesmo projeto
            //Console.WriteLine(amiga.UsoMuitoPhotoshop); objeto privado
        }

    }
    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();

        }
    }
}
