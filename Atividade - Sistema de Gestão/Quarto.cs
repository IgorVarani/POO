using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade___Sistema_de_Gestão
{
    public class Quarto
    {
        public int Numero { get; set; }
        public string tipoquarto;
        public string Tipo
        {
            get
            {
                return tipoquarto;
            }
            set
            {
                if (value == "Simples" || value == "Duplo" || value == "Suíte")
                {
                    tipoquarto = value;
                }

                else
                {
                    Console.WriteLine("Tipo de quarto inválido. Use 'Simples', 'Duplo' ou 'Suíte'.");
                }
            }
        }
        public double PrecoDiaria { get; set; }
        public bool Disponivel { get; set; }

        public void ExibirDetalhes()
        {
            Console.WriteLine(">>> Informações do Quarto <<<");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Preço da Diária: {PrecoDiaria}");
            Console.WriteLine($"Disponível: {(Disponivel ? "Sim." : "Não.")}");
        }

        public void Liberar()
        {
            Disponivel = true;
        }
        public void Ocupar()
        {
            Disponivel = false;
        }
    }
}