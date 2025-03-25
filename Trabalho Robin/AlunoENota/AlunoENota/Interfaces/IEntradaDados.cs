using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Robin.Interfaces
{
    public interface IEntradaDados
    {
        public void ReceberDados(
            out int ra,
            out string nome,
            out double notaProva,
            out double notaTrabalho
        );
    }
}
