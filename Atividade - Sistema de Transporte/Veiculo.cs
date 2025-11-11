using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade___Sistema_de_Transporte
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public virtual void Ligar()
        {
            Console.WriteLine($"O veículo {Modelo} está ligado!");
        }
    }
}