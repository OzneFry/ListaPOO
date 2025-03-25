using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoUniaraxa.Interfaces
{
    public interface IOperacoesBancarias
    {
        void Depositar(double valor);
        bool Sacar(double valor);
        double ObterSaldo();
    }
}
