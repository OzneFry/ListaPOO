using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaLampada.Interfaces;

namespace SistemaLampada
{
    public class InteracaoUsuarioConsole : IInteracaoUsuario
    {
        public int ExibirMenu()
        {
            Console.WriteLine("\n=== Controle de Lâmpada ===");
            Console.WriteLine("1 - Ligar lâmpada");
            Console.WriteLine("2 - Desligar lâmpada");
            Console.WriteLine("3 - Ver estado atual");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            int opcao;
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 4)
            {
                Console.Write("Opção inválida. Escolha entre 1 e 4: ");
            }
            return opcao;
        }

        public void MostrarMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
