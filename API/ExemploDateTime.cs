using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);


            //sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);  //ou
            Console.WriteLine(DateTime.Today);

            //com horas

            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual); //ou
            Console.WriteLine(DateTime.Now);

            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D")); // data completa
            Console.WriteLine(diaAtual.ToString("G")); 
            Console.WriteLine(diaAtual.ToString("g")); 
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm")); 
        }
    }    

}
