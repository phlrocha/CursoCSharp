﻿using System;
using System.IO;

namespace CursoCSharp.API
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"D:/Source/CursoCSharp/";

            var dirInfo = new DirectoryInfo(dirProjeto);

            Console.WriteLine("===== Pastas =====");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("===== Arquivos =====");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}
