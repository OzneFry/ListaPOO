using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Robin.Interfaces;

namespace Trabalho_Robin
{
    public class EntradaDadosConsole : IEntradaDados
    {
        public void ReceberDados(
            out int ra,
            out string nome,
            out double notaProva,
            out double notaTrabalho
        )
        {
            Console.WriteLine("Digite os dados do aluno:");

            // Receber RA
            Console.Write("RA (número inteiro): ");
            while (!int.TryParse(Console.ReadLine(), out ra))
            {
                Console.Write("Por favor, digite um RA válido (número inteiro): ");
            }

            // Receber Nome
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            // Receber Nota da Prova
            do
            {
                Console.Write("Nota da Prova (0-10): ");
            } while (
                !double.TryParse(Console.ReadLine(), out notaProva)
                || notaProva < 0
                || notaProva > 10
            );

            // Receber Nota do Trabalho
            do
            {
                Console.Write("Nota do Trabalho (0-10): ");
            } while (
                !double.TryParse(Console.ReadLine(), out notaTrabalho)
                || notaTrabalho < 0
                || notaTrabalho > 10
            );
        }
    }
}
