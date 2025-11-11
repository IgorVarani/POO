using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2._Sistema_de_Funcionários
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public abstract void CalcularSalario();

        public void ExibirResumo()
        {
            Console.WriteLine($"Nome: {Nome}\n");
            Console.WriteLine($"Salário: {Salario:C}\n");
        }
    }
}