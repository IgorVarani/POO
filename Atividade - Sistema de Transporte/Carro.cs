using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade___Sistema_de_Transporte
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public override void Ligar()
        {
            Console.WriteLine($"O carro {Modelo} está pronto para rodar!");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantidade de Portas: {QuantidadePortas}");
        }

        //* Implementando interface ICombustivel
        public void Abastecer(double litros)
        {
            Console.WriteLine($"Abastecendo o carro {Modelo} com {litros} litros de combustível.");
        }
    }
}