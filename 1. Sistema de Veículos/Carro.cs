using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace _1._Sistema_de_Veículos
{
    public class Carro : Veiculo
    {
        public override void CalcularRevisao()
        {
            Console.WriteLine("Revisão do Carro: A cada 10.000Km");
        }
        public string custoFixoRC
        {
            get
            {
                return "R$ 500,00";
            }
            set
            {
                custoFixoRC = value;
            }
        }
    }
}