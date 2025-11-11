namespace _3._Sistema_de_PdJ;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(">>> Sistema de Personagens de Jogo <<<\n");

        Guerreiro guerreiro = new Guerreiro
        {
            Nome = "Aatrox",
            Nivel = 5,
        };

        Mago mago = new Mago
        {
            Nome = "Sylas",
            Nivel = 7,
        };

        guerreiro.ExibirStatus();
        mago.ExibirStatus();

        guerreiro.CalcularPoder();
        mago.CalcularPoder();

        Console.WriteLine("Pressione qualquer tecla para sair...\n");
        Console.ReadKey();
    }
}
