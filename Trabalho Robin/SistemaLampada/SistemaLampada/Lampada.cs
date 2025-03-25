using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaLampada.Interfaces;

namespace SistemaLampada
{
    public class Lampada
    {
        private readonly IEstadoLampada _controle;
        private readonly IInteracaoUsuario _interface;

        public Lampada(IEstadoLampada controle, IInteracaoUsuario interfaceUsuario)
        {
            _controle = controle;
            _interface = interfaceUsuario;
        }

        public void Ligar()
        {
            _controle.Ligar();
            _interface.MostrarMensagem("Lâmpada ligada!");
        }

        public void Desligar()
        {
            _controle.Desligar();
            _interface.MostrarMensagem("Lâmpada desligada!");
        }

        public void ExibirEstado()
        {
            _interface.MostrarMensagem($"Estado atual: {_controle.ObterEstado()}");
        }
    }
}
