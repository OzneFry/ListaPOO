using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaLampada.Interfaces;

namespace SistemaLampada
{
    public class ControleLampada : IEstadoLampada
    {
        private bool _ligada;

        public ControleLampada(bool estadoInicial = false)
        {
            _ligada = estadoInicial;
        }

        public void Ligar()
        {
            _ligada = true;
        }

        public void Desligar()
        {
            _ligada = false;
        }

        public string ObterEstado()
        {
            return _ligada ? "Ligada" : "Desligada";
        }
    }
}
