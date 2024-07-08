using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISujetoRevista
    {
        void Suscribir(IObserverUsuario usuario);
        void Desuscribir(IObserverUsuario suario);
        void Notificar();
    }
}
