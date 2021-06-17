using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public abstract class Celular // não pode ser instanciada diretamente,somente em classes herdeiras 
    {
        public abstract string Assistente(); // a classe herdeira deve instanciar 

        public string Tocar()
        {
            return "Trim trim trim";
        }
    }
        public class Samsung : Celular
        {
            public override string Assistente()
            {
                return "Olá, meu nome é Bixby";
            }
        }

        public class Iphone : Celular
        {
            public override string Assistente() // herdado da classe Pai, deve ser instanciada com override
            {
                return "Olá, meu nome é Siri";
            }

        }
  

    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
               new Iphone(),
               new Samsung()
            };
            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
            
        }
    }
}
