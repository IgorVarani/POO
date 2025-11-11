namespace _1._Sistema_de_Veículos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(">>> Sistema de Veículos <<<");

        Carro carro = new Carro()
        {
            Modelo = "Toyota Corolla Xei Prata",
            Ano = 2008
        };

        Moto moto = new Moto()
        {
            Modelo = "Kawasaki Ninja ZX-10R Verde",
            Ano = 2020
        };

        carro.ExibirResumo();
        carro.CalcularRevisao();
        Console.WriteLine($">> Custo da Revisão do Carro: {carro.custoFixoRC} <<");

        moto.ExibirResumo();
        moto.CalcularRevisao();
        Console.WriteLine($">> Custo da Revisão da Moto: {moto.custoFixoRM} <<");
    }
}