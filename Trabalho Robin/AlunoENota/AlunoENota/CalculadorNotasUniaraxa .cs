using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Robin.Interfaces;

namespace Trabalho_Robin
{
    public class CalculadorNotasUniaraxa : ICalculadorNotas
    {
        public double CalcularMedia(double notaProva, double notaTrabalho)
        {
            return (notaProva + notaTrabalho) / 2;
        }

        public bool VerificarAprovacao(double notaFinal, out double notaNecessaria)
        {
            if (notaFinal >= 6)
            {
                notaNecessaria = 0;
                return true;
            }

            notaNecessaria = (5 - (notaFinal * 0.6)) / 0.4;
            return false;
        }
    }
}
