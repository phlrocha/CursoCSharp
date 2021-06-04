using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento; // com o readonly, o valor se torna imutavel após ser iniciado no construtor


        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        
        public string GetDataDeNascimento()
        {
            return String.Format($"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}");
        }
    
    }   
    
    
    
    class Readonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Ana Silvia", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        
        }

    }
}

