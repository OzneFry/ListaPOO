using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaLampada.Interfaces
{
    public interface IInteracaoUsuario
    {
        int ExibirMenu();
        void MostrarMensagem(string mensagem);
    }
}
