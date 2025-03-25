using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeProdutos.Interfaces
{
    public interface IEntradaDadosProduto
    {
        void ReceberDadosProduto(out string nome, out double preco, out int quantidade);
        int LerQuantidadeOperacao(string mensagem);
        int LerOpcaoMenu();
    }
}