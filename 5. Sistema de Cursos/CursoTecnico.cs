using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5._Sistema_de_Cursos
{
    public class CursoTecnico : Curso
    {
        public override void CalcularPreco()
        {
            double preco = Horas * 20;
            Console.WriteLine($"Preço do Curso Técnico {Nome}: R$ {preco}");
        }
    }
}