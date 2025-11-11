using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5._Sistema_de_Cursos
{
    public class CursoSuperior : Curso
    {
        public override void CalcularPreco()
        {
            double preco = Horas * 40;
            Console.WriteLine($"Preço do Curso Superior {Nome}: R$ {preco}");
        }
    }
}