using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4._Sistema_de_Animais
{
    public class Elefante : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Som: Barrito");
        }

        public override void Dieta()
        {
            Console.WriteLine("Dieta: Herbívoro");
        }
    }
}