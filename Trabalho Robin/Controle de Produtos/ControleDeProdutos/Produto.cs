using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeProdutos.Interfaces;

namespace ControleDeProdutos
{
    public class Produto
    {
        private readonly IOperacoesEstoque _operacoes;

        public string Nome { get; }
        public double Preco { get; }

        public Produto(string nome, double preco, IOperacoesEstoque operacoes)
        {
            Nome = nome;
            Preco = preco;
            _operacoes = operacoes;
        }

        public void AdicionarEstoque(int quantidade)
        {
            _operacoes.AdicionarEstoque(quantidade);
            Console.WriteLine($"{quantidade} unidades adicionadas ao estoque.");
        }

        public void RemoverEstoque(int quantidade)
        {
            if (_operacoes.RemoverEstoque(quantidade))
            {
                Console.WriteLine($"{quantidade} unidades removidas do estoque.");
            }
            else
            {
                Console.WriteLine("Quantidade indisponível no estoque.");
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine(_operacoes.ObterDetalhes());
        }
    }
}
