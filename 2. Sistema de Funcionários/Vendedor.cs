using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2._Sistema_de_Funcionários
{
    public class Vendedor : Funcionario
    {
        public override void CalcularSalario()
        {
            //* Vendedores ganham 20% de bônus sobre o salário base.
            Salario += Salario * 0.2;
        }
    }
}