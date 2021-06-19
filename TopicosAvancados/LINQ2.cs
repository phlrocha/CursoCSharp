using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
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

            //Single - retorna um unico valor de uma lista
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            //SingleOrDefault - retorna um unico valor de uma lista( caso nao encontre, retorna o valor padrão)
            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if(fulano == null)
            {
                Console.WriteLine("Aluno Inexistente!!!");
            }

            // First - retorna o primeiro valor encontrado
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            // First - retorna o primeiro valor encontrado( caso nao encontre, retorna o valor padrão)
            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("Aluno Inexistente!!!");
            }

            // LastOrDefault - retorna o primeiro valor encontrado( caso nao encontre, retorna o valor padrão)
            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);


            // Skip - ignora uma quantidade da lista ao retornar os dados( pula)
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            //Max = maior valor 
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);
            
            //Min = menor valor 
            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            //Sum - somatorio
            var somaNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somaNotas);

            //Average = media 
            var media = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(media);

            var mediaAprovados = alunos.Where(a => a.Nota >=7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaAprovados);
        }

    }
}
