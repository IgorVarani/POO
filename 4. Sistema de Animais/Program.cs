namespace _4._Sistema_de_Animais;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(">>> Sistema de Animais <<<");

        Animal leao = new Leao { Nome = "Leão" };
        Animal elefante = new Elefante { Nome = "Elefante" };

        Console.WriteLine($"\nAnimal: {leao.Nome}");
        leao.EmitirSom();
        leao.Dieta();

        Console.WriteLine($"\nAnimal: {elefante.Nome}");
        elefante.EmitirSom();
        elefante.Dieta();

        Console.WriteLine("\nPressione qualquer tecla para sair...\n");
    }
}
