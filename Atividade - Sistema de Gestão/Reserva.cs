using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade___Sistema_de_Gestão
{
    public class Reserva
    {
        Hospede hospede1 = new Hospede()
        {
            Nome = "Alice Wonderland",
            CPF = "123.456.789-00",
            Telefone = "(11) 91234-5678"
        };
         Quarto quarto1 = new Quarto()
        {
            Numero = 101,
            Tipo = "Simples",
            PrecoDiaria = 150.00,
            Disponivel = true
        };
        public int DiasReservados { get; set; }

        public void CalcularValorTotal()
        {
            double valorTotal = DiasReservados * quarto1.PrecoDiaria;
            Console.WriteLine($"O valor da reserva é: {valorTotal}");
        }
        public void ResumoReserva()
        {
            Console.WriteLine(">>> Resumo da Reserva <<<");
            hospede1.ExibirInformacoes();
            quarto1.ExibirDetalhes();
            Console.WriteLine($"Dias Reservados: {DiasReservados}");
            CalcularValorTotal();
        }
    }
}