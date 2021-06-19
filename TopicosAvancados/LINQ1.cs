﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;


    }

    class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno(){ Nome = "Pedro", Idade = 27, Nota = 10.0},
                new Aluno(){ Nome = "Andre", Idade = 23, Nota = 4.3},
                new Aluno(){ Nome = "Ana", Idade = 22, Nota = 9.5},
                new Aluno(){ Nome = "Jorge", Idade = 28, Nota = 8.5},
                new Aluno(){ Nome = "Ana", Idade = 21, Nota = 7.5},
                new Aluno(){ Nome = "Ritta", Idade = 24, Nota = 10.0},
                new Aluno(){ Nome = "Marcio", Idade = 25, Nota = 5.7},
            };

            Console.WriteLine("== Aprovados ===========" );
            var aprovados = alunos.Where(a => a.Nota > 7).OrderBy(a => a.Nome);
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("== Chamada ===========");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("== Aprovados (por idade) ===========");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach( var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
