using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Robin.Interfaces
{
    public interface ICalculadorNotas
    {
        public double CalcularMedia(double notaProva, double notaTrabalho);
        public bool VerificarAprovacao(double notaFinal, out double notaNecessaria);
    }
}
