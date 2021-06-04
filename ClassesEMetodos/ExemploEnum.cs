using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
     public enum Genero { Acao, Aventura, Terror, Animacao, Comedia }; // Cada elemento do enum tem um valor atribulado, começando com 0

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    
    
    
    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao; // id de Animação dentro do Enum = 3
            Console.WriteLine(id);


            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine($"{filmeParaFamilia.Titulo} é {filmeParaFamilia.GeneroDoFilme}");
        }
    }
}
