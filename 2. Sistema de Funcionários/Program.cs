namespace _2._Sistema_de_Funcionários;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(">>> Sistema de Funcionários <<<\n");

        Gerente gerente = new Gerente
        {
            Nome = "Ana Silva",
            Salario = 5000
        };

        Vendedor vendedor = new Vendedor
        {
            Nome = "Carlos Souza",
            Salario = 3000
        };

        gerente.CalcularSalario();
        vendedor.CalcularSalario();

        Console.WriteLine(">> Resumo do Gerente<< \n");
        gerente.ExibirResumo();

        Console.WriteLine(">> Resumo do Vendedor<< \n");
        vendedor.ExibirResumo();
    }
}
