using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeProdutos.Interfaces
{
    public interface IOperacoesEstoque
    {
        void AdicionarEstoque(int quantidade);
        bool RemoverEstoque(int quantidade);
        string ObterDetalhes();
    }
}
