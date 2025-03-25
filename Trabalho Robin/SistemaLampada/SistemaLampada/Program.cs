using SistemaLampada;
using SistemaLampada.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        // Criar as dependências
        IEstadoLampada controle = new ControleLampada();
        IInteracaoUsuario interfaceUsuario = new InteracaoUsuarioConsole();

        // Criar a lâmpada
        Lampada lampada = new Lampada(controle, interfaceUsuario);

        // Menu interativo
        int opcao;
        do
        {
            opcao = interfaceUsuario.ExibirMenu();

            switch (opcao)
            {
                case 1: // Ligar
                    lampada.Ligar();
                    break;

                case 2: // Desligar
                    lampada.Desligar();
                    break;

                case 3: // Ver estado
                    lampada.ExibirEstado();
                    break;

                case 4: // Sair
                    interfaceUsuario.MostrarMensagem("Encerrando o controle da lâmpada...");
                    break;
            }
        } while (opcao != 4);
    }
}
