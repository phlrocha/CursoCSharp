using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpicional
    {
        double desconto = 0.1;

        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }

            set
            {
                nome = value;
            }
        }

        //proriedade autoimplementada
        public double Preco { get; set; }

        //somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //lambda
        }

        public CarroOpicional()
        {

        }

        public CarroOpicional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }



    }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpicional("Ar Condicionado", 3499.9); //usando construtor criado
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpicional(); // usando construtor padrão
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);



        }




    }
}





   