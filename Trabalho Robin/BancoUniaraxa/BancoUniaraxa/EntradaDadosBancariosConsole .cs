using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoUniaraxa.Interfaces;

namespace BancoUniaraxa
{
    public class EntradaDadosBancariosConsole : IEntradaDadosBancarios
    {
        public void ReceberDadosConta(
            out string numeroConta,
            out string titular,
            out double saldoInicial
        )
        {
            Console.WriteLine("=== Cadastro de Nova Conta ===");

            Console.Write("Número da Conta: ");
            numeroConta = Console.ReadLine();

            Console.Write("Nome do Titular: ");
            titular = Console.ReadLine();

            Console.Write("Saldo Inicial: ");
            while (!double.TryParse(Console.ReadLine(), out saldoInicial) || saldoInicial < 0)
            {
                Console.Write("Por favor, digite um saldo inicial válido (≥ 0): ");
            }
        }

        public double LerValorOperacao(string mensagem)
        {
            double valor;
            Console.Write(mensagem);
            while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.Write("Por favor, digite um valor válido (> 0): ");
            }
            return valor;
        }

        public int LerOpcaoMenu()
        {
            Console.WriteLine("\n=== Menu ===");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Ver Saldo");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            int opcao;
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 4)
            {
                Console.Write("Opção inválida. Escolha entre 1 e 4: ");
            }
            return opcao;
        }
    }
}
