using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade___Sistema_de_Gestão
{
    public class ReservaVIP : Reserva
    {
        Hospede hospede2 = new Hospede()
        {
            Nome = "Edward Elric",
            CPF = "987.654.321-00",
            Telefone = "(21) 99876-5432"
        };
        Quarto quarto2 = new Quarto()
        {
            Numero = 202,
            Tipo = "Suíte",
            PrecoDiaria = 300.00,
            Disponivel = true
        };
        public decimal Desconto { get; set; }

        public void CalcularValorTotalVIP()
        {
            double valorTotal = DiasReservados * quarto2.PrecoDiaria * (1 - (double)Desconto % 100); //! O 2° * converte em porcentagem.
            Console.WriteLine($"O valor da reserva com desconto é: {valorTotal}");
        }

        public void ResumoReservaVIP()
        {
            Console.WriteLine(">>> Resumo da Reserva VIP <<<");
            hospede2.ExibirInformacoes();
            quarto2.ExibirDetalhes();
            Console.WriteLine($"Dias Reservados: {DiasReservados}");
            CalcularValorTotalVIP();
        }
    }
}