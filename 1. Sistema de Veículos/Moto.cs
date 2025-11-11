using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._Sistema_de_Veículos
{
    public class Moto : Veiculo
    {
        public override void CalcularRevisao()
        {
            Console.WriteLine("Revisão da Moto: A cada 5.000Km");
        }
        public string custoFixoRM
        {
            get
            {
                return "R$ 300,00";
            }
            set
            {
                custoFixoRM = value;
            }
        }
    }
}