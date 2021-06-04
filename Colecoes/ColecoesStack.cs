using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);  // push - adiciona elementos no stack
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop:: {pilha.Pop()}"); // \n - pula uma linha; Pop-exibe e  remove o item a pilha
         
            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek:: {pilha.Peek()}");// peek -exibe mas nao remove o elemento da pilha
            Console.WriteLine(pilha.Count);

        }




            
    }
}
