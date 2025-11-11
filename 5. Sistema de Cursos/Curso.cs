using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5._Sistema_de_Cursos
{
    public abstract class Curso
    {
        public string Nome { get; set; }
        public int Horas { get; set; }

        public abstract void CalcularPreco();

        public void ExibirResumo()
        {
            Console.WriteLine($"Curso: {Nome}, Horas: {Horas}");
        }
    }
}