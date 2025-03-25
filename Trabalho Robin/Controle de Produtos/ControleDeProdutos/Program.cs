using ControleDeProdutos;
using ControleDeProdutos.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        // Criar as dependências
        IEntradaDadosProduto entradaDados = new EntradaDadosProdutoConsole();
        IOperacoesEstoque operacoes;

        // Receber dados do produto
        entradaDados.ReceberDadosProduto(out string nome, out double preco, out int quantidade);

        operacoes = new OperacoesEstoquePadrao(nome, preco, quantidade);

        // Criar o produto
        Produto produto = new Produto(nome, preco, operacoes);

        // Menu interativo
        int opcao;
        do
        {
            opcao = entradaDados.LerOpcaoMenu();

            switch (opcao)
            {
                case 1: // Adicionar ao estoque
                    int qtdAdicionar = entradaDados.LerQuantidadeOperacao("Quantidade a adicionar: ");
                    produto.AdicionarEstoque(qtdAdicionar);
                    break;

                case 2: // Remover do estoque
                    int qtdRemover = entradaDados.LerQuantidadeOperacao("Quantidade a remover: ");
                    produto.RemoverEstoque(qtdRemover);
                    break;

                case 3: // Ver detalhes
                    produto.ExibirDetalhes();
                    break;

                case 4: // Sair
                    Console.WriteLine("Encerrando o sistema de estoque...");
                    break;
            }
        } while (opcao != 4);
    }
}
