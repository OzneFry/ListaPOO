using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeProdutos.Interfaces;

namespace ControleDeProdutos
{
    public class EntradaDadosProdutoConsole : IEntradaDadosProduto
    {
        public void ReceberDadosProduto(out string nome, out double preco, out int quantidade)
        {
            Console.WriteLine("=== Cadastro de Novo Produto ===");

            Console.Write("Nome do Produto: ");
            nome = Console.ReadLine();

            Console.Write("Preço Unitário: ");
            while (!double.TryParse(Console.ReadLine(), out preco) || preco <= 0)
            {
                Console.Write("Por favor, digite um preço válido (> 0): ");
            }

            Console.Write("Quantidade Inicial: ");
            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0)
            {
                Console.Write("Por favor, digite uma quantidade válida (≥ 0): ");
            }
        }

        public int LerQuantidadeOperacao(string mensagem)
        {
            int quantidade;
            Console.Write(mensagem);
            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
            {
                Console.Write("Por favor, digite uma quantidade válida (> 0): ");
            }
            return quantidade;
        }

        public int LerOpcaoMenu()
        {
            Console.WriteLine("\n=== Menu de Estoque ===");
            Console.WriteLine("1 - Adicionar ao estoque");
            Console.WriteLine("2 - Remover do estoque");
            Console.WriteLine("3 - Ver detalhes do produto");
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
