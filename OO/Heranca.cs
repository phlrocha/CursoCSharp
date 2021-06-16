using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima; // protegido e somente leitura
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

            protected int AlterarVelocidade(int delta) // protegido
        {
            int novaVelocidade = VelocidadeAtual + delta;
            
            if(novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if(novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }
        public virtual int Acelerar() // virtual = permite que o método sofra um override(sobreescrito)
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno: Carro
    {
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        public new int Frear() // o usu do "new" oculta o método "Frear" da classe pai
        {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar()); // acelarando 15 (usando override)
            Console.WriteLine(carro3.Acelerar());// acelarando 15 (usando override)
            Console.WriteLine(carro3.Frear()); //freando 5 (a ocultação do metodo pai nao funciona nesse caso
            Console.WriteLine(carro3.Acelerar());// acelarando 15 (usando override)
            Console.WriteLine(carro3.Frear());//freando 5 (a ocultação do metodo pai nao funciona nesse caso
            Console.WriteLine(carro3.Frear());//freando 5 (a ocultação do metodo pai nao funciona nesse caso

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
