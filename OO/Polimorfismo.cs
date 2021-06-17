﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;

        public Comida()
        {
        }

        public Comida(double peso)
        {
            Peso = peso;
        }
    }


    public class Feijao : Comida // recebe os atributos por herança
    {
      public Feijao(double peso) : base(peso) // construtor base
        {

        }
    }

    public class Arroz : Comida // recebe os atributos por herança
    {
      
    }

    public class Carne : Comida // recebe os atributos por herança
    {
      
    }

    public class Pessoa
    {
        public double Peso;

        //public void Comer(Feijao feijao)
        //{
        //    Peso += feijao.Peso;
        //}
        //public void Comer(Arroz arroz)
        //{
        //    Peso += arroz.Peso;
        //}
        //public void Comer(Carne carne)
        //{
        //    Peso += carne.Peso;
        //}

        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }

    }
    class Polimorfismo
    {
        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao(0.3); // usando construtor base
            //ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Novo peso do cliente: {cliente.Peso} kg");
        }
    }
}
