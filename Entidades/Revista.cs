using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Revista : ISujetoRevista
    {
        private List<IObserverUsuario> usuarios;

        string _noticia;
        public string Noticia
        {
            get
            {
                return _noticia;
            }
            set
            {
                _noticia = value;
                this.Notificar();
            }
        }
        public string Categoria { get; set; }

        public Revista(string categoria)
        {
            _noticia = string.Empty;
            Categoria = categoria;
            usuarios = new List<IObserverUsuario>();
        }

        public void Desuscribir(IObserverUsuario usuario)
        {
            if (usuarios.Contains(usuario))
            {
                usuarios.Remove(usuario);
                Console.WriteLine("El usuario "+ ((Usuario)usuario).Nombre + "se ha desuscrito correctamente");
            }
            else
            {
                Console.WriteLine("El usuario no se encuentra suscrito");
            }
        }

        public void Notificar()
        {
            foreach(var usuario in usuarios)
            {
                usuario.Actualizar(this);
            }

            if(usuarios.Count == 0)
            {
                Console.WriteLine("No hay suscripciones en la Categoria "+ Categoria);
            }

            Console.WriteLine("----------------------------------------------------------------------------");
        }

        public void Suscribir(IObserverUsuario usuario)
        {
            if (!usuarios.Contains(usuario))
            {
                usuarios.Add(usuario);
                Console.WriteLine("El usuario " + ((Usuario)usuario).Nombre + " se ha suscrito a la Categoria "+ Categoria);
            }
            else
            {
                Console.WriteLine("Este usuario ya se encuentra suscrito");
            }
        }

        public void PublicarNoticia(string noticia)
        {
            this.Noticia = noticia;
            Console.WriteLine("Se ha publicado una nueva noticia en la Categoria " + Categoria +": " + noticia);
        }
    }
}
