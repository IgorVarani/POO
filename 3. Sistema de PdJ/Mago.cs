using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._Sistema_de_PdJ
{
    public class Mago : Personagem
    {
        public override void CalcularPoder()
        {
            //* O poder do mago é seu nível multiplicado por 8 somado com 20.
            int Poder = (Nivel * 8) + 20;
            Console.WriteLine($"Poder do Mago {Nome}: {Poder}\n");
        }
    }
}