using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Robin.Interfaces;

namespace Trabalho_Robin
{
    public class Aluno
    {
        private readonly ICalculadorNotas _calculador;

        public int RA { get; set; }
        public string Nome { get; set; }
        public double NotaProva { get; set; }
        public double NotaTrabalho { get; set; }
        public double NotaFinal { get; private set; }

        public Aluno(ICalculadorNotas calculador)
        {
            _calculador = calculador;
        }

        public void CalcularMedia()
        {
            NotaFinal = _calculador.CalcularMedia(NotaProva, NotaTrabalho);
        }

        public bool CalcularNotaFinal()
        {
            bool aprovado = _calculador.VerificarAprovacao(NotaFinal, out double notaNecessaria);

            if (aprovado)
            {
                Console.WriteLine("Aluno aprovado! Parabéns!");
            }
            else
            {
                Console.WriteLine(
                    $"Aluno em prova final. Precisa de {notaNecessaria:F2} na prova final."
                );
            }

            return aprovado;
        }

        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"Nota Final: {NotaFinal:F2}");
        }
    }
}
