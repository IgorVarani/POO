namespace Atividade___Sistema_de_Gestão;

class Program
{
    static void Main(string[] args)
    {
        //! Lista de Reservas com Construtor
        //* Hóspedes com Construtor
        Console.WriteLine(">>> Reserva 1 <<<");

        Hospede hospede1 = new Hospede()
        {
            Nome = "Alice Wonderland",
            CPF = "123.456.789-00",
            Telefone = "(11) 91234-5678"
        };

        Hospede hospede2 = new Hospede()
        {
            Nome = "Edward Elric",
            CPF = "987.654.321-00",
            Telefone = "(21) 99876-5432"
        };

        //* Quartos com Construtor
        Quarto quarto1 = new Quarto()
        {
            Numero = 101,
            Tipo = "Simples",
            PrecoDiaria = 150.00,
            Disponivel = true
        };

        Quarto quarto2 = new Quarto()
        {
            Numero = 202,
            Tipo = "Suíte",
            PrecoDiaria = 300.00,
            Disponivel = true
        };

        //* Reserva (padrão) com Construtor
        Reserva reserva1 = new Reserva()
        {
            DiasReservados = 3
        };

        //* Reserva (VIP) com Construtor
        ReservaVIP reservaVIP1 = new ReservaVIP()
        {
            DiasReservados = 5,
            Desconto = 10m
        };

        //* Exibir Resumo das Reservas
        reserva1.ResumoReserva();
        reservaVIP1.ResumoReservaVIP();
    }
}
