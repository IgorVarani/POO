using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._Sistema_de_Veículos
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }

        //* Método abstrato:
        public abstract void CalcularRevisao();

        //* Método comum:
        public void ExibirResumo()
        {
            Console.WriteLine($"Modelo: {Modelo}, Ano: {Ano}");
        }
    }
}