using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade___Sistema_de_Transporte
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public override void Ligar()
        {
            Console.WriteLine($"A moto {Modelo} de {Cilindrada}cc está pronta!");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Cilindrada: {Cilindrada}cc");
        }

        //* Implementando interface ICombustivel
        public void Abastecer(double litros)
        {
            Console.WriteLine($"Abastecendo a moto {Modelo} com {litros} litros de combustível.");
        }
    }
}