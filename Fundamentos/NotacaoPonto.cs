using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, "World!").Replace("World", " Mundo");
            Console.WriteLine(saudacao);
            // insert = adicionar um valor em determinada posição
            // replace = substitui  um valor por outro 

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);

            // o uso de "?" serve para que não ocorra um erro caso a variavel em
            // questão nao esteja definida. No caso, a variavel está nula (null).
        }
    }
}
