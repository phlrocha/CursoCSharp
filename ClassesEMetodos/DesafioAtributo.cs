using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
  class DesafioAtributo
    {
        int a = 10; //atributo de instancia
        
        public static void Executar()
        {

            //como o atributo "a" não é um atributo estático, foi necessario criar uma instancia para escreve-lo no console
           // a variável "teste" foi criada usando o construtor padrão da classe DesafioAtributo, cujo unico parâmetro é a variável "a"
            DesafioAtributo teste = new DesafioAtributo();
            Console.WriteLine(teste.a); 

        }
    }
}
