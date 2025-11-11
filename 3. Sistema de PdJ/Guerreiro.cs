using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._Sistema_de_PdJ
{
    public class Guerreiro : Personagem
    {
        public override void CalcularPoder()
        {
            //* O poder do guerreiro é seu nível multiplicado por 10.
            int Poder = Nivel * 10;
            Console.WriteLine($"Poder do Guerreiro {Nome}: {Poder}\n");
        }
    }
}