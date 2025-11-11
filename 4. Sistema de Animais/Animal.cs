using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4._Sistema_de_Animais
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract void EmitirSom();
        public abstract void Dieta();
    }
}