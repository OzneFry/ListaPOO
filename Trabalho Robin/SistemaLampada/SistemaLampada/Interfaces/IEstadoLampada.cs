using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaLampada.Interfaces
{
    public interface IEstadoLampada
    {
        void Ligar();
        void Desligar();
        string ObterEstado();
    }
}
