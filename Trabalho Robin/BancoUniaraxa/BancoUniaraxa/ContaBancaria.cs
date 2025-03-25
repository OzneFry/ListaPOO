using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoUniaraxa.Interfaces;

namespace BancoUniaraxa
{
    public class ContaBancaria
    {
        private readonly IOperacoesBancarias _operacoes;

        public string NumeroConta { get; set; }
        public string Titular { get; }

        public ContaBancaria(string numeroConta, string titular, IOperacoesBancarias operacoes)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            _operacoes = operacoes;
        }

        public void Depositar(double valor)
        {
            _operacoes.Depositar(valor);
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
        }

        public void Sacar(double valor)
        {
            if (_operacoes.Sacar(valor))
            {
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {_operacoes.ObterSaldo():C}");
        }
    }
}
