using Trabalho_Robin;
using Trabalho_Robin.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        ICalculadorNotas calculador = new CalculadorNotasUniaraxa();
        IEntradaDados entradaDados = new EntradaDadosConsole();

        Aluno aluno = new Aluno(calculador);

        entradaDados.ReceberDados(
            out int ra,
            out string nome,
            out double notaProva,
            out double notaTrabalho
        );

        aluno.RA = ra;
        aluno.Nome = nome;
        aluno.NotaProva = notaProva;
        aluno.NotaTrabalho = notaTrabalho;

        aluno.CalcularMedia();
        aluno.ImprimirNotaFinal();
        bool aprovado = aluno.CalcularNotaFinal();

        Console.WriteLine($"Status: {(aprovado ? "Aprovado" : "Prova Final")}");
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadLine();
    }
}
