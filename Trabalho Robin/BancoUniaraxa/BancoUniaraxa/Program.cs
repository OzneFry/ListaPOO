using BancoUniaraxa;
using BancoUniaraxa.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        IEntradaDadosBancarios entradaDados = new EntradaDadosBancariosConsole();
        IOperacoesBancarias operacoes;

        entradaDados.ReceberDadosConta(
            out string numeroConta,
            out string titular,
            out double saldoInicial
        );

        operacoes = new OperacoesBancariasPadrao(saldoInicial);

        ContaBancaria conta = new ContaBancaria(numeroConta, titular, operacoes);

        int opcao;
        do
        {
            opcao = entradaDados.LerOpcaoMenu();

            switch (opcao)
            {
                case 1: // Depositar
                    double valorDeposito = entradaDados.LerValorOperacao("Valor para depósito: ");
                    conta.Depositar(valorDeposito);
                    break;

                case 2: // Sacar
                    double valorSaque = entradaDados.LerValorOperacao("Valor para saque: ");
                    conta.Sacar(valorSaque);
                    break;

                case 3: // Ver Saldo
                    conta.ExibirSaldo();
                    break;

                case 4: // Sair
                    Console.WriteLine("Obrigado por utilizar nossos serviços!");
                    break;
            }
        } while (opcao != 4);
    }
}
