using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._Sistema_de_PdJ
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }

        public abstract void CalcularPoder();

        public void ExibirStatus()
        {
            Console.WriteLine($"Nome: {Nome}, Nível: {Nivel}\n");
        }
    }
}