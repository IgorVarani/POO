namespace Atividade___Sistema_de_Transporte;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n>>> Sistema de Transporte <<<\n");
        
        //! Uso de classe concreta.
        //* Carro:
        Carro carro = new Carro()
        {
            Marca = "Toyota",
            Modelo = "Corolla Xei Prata",
            Ano = 2008,
            QuantidadePortas = 4
        };
        carro.Ligar();
        

    }
}
