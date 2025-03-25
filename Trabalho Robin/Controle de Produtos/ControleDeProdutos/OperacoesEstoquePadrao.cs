using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeProdutos.Interfaces;

namespace ControleDeProdutos
{
    public class OperacoesEstoquePadrao : IOperacoesEstoque
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public OperacoesEstoquePadrao(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public void AdicionarEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                _quantidade += quantidade;
            }
        }

        public bool RemoverEstoque(int quantidade)
        {
            if (quantidade > 0 && _quantidade >= quantidade)
            {
                _quantidade -= quantidade;
                return true;
            }
            return false;
        }

        public string ObterDetalhes()
        {
            return $"Nome: {_nome}\nPreço: {_preco:C}\nQuantidade em estoque: {_quantidade}";
        }
    }
}
