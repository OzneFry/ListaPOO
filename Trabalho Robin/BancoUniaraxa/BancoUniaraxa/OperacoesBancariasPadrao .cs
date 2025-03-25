using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoUniaraxa.Interfaces;

namespace BancoUniaraxa
{
    public class OperacoesBancariasPadrao : IOperacoesBancarias
    {
        private double _saldo;

        public OperacoesBancariasPadrao(double saldoInicial)
        {
            _saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && _saldo >= valor)
            {
                _saldo -= valor;
                return true;
            }
            return false;
        }

        public double ObterSaldo()
        {
            return _saldo;
        }
    }
}
