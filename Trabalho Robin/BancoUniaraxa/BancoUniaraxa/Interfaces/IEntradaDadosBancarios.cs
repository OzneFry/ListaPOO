using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoUniaraxa.Interfaces
{
    public interface IEntradaDadosBancarios
    {
        void ReceberDadosConta(out string numeroConta, out string titular, out double saldoInicial);
        double LerValorOperacao(string mensagem);
        int LerOpcaoMenu();
    }
}
