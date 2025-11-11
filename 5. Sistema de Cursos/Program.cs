namespace _5._Sistema_de_Cursos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(">>> Sistema de Cursos <<<\n");

        Curso tecnico = new CursoTecnico
        {
            Nome = "Técnico em Multimídia",
            Horas = 200
        };

        Curso superior = new CursoSuperior
        {
            Nome = "Bacharelado em Design Gráfico",
            Horas = 800
        };

        tecnico.ExibirResumo();
        tecnico.CalcularPreco();

        superior.ExibirResumo();
        superior.CalcularPreco();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
