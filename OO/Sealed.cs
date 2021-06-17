using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{

    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho   // não permite herança por ser uma classe "Sealed"
    //{

    //}

    // metodos sealed não podem ser reescritos com override, somente usando o new para instanciar novamente

    class Sealed
    {
        public static void Executar()
        {

        }
    }
}
