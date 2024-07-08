using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : IObserverUsuario
    {
        public string Nombre { get; set; }

        public Usuario(string nombre)
        {
            Nombre = nombre;
        }
        public void Actualizar(Revista revista)
        {
            Console.WriteLine("Notificacion para " + Nombre + ": Nueva noticia en la Categoria " + revista.Categoria + ": " + revista.Noticia);
        }
    }
}
