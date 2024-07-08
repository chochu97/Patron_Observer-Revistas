using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverRevistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Revista revistPesca = new Revista("Pesca");
            Revista revistDeporte = new Revista("Deporte");
            Revista revistHumor = new Revista("Humor");

            Usuario user = new Usuario("Flor");
            Usuario user1 = new Usuario("Ambar");

            revistPesca.Suscribir(user);
            revistDeporte.Suscribir(user1);
            revistDeporte.Suscribir(user);
            revistHumor.Suscribir(user1);

            revistPesca.PublicarNoticia("Mejores lugar para pescar en julio");
            revistDeporte.PublicarNoticia("Messi se lesiona");
            revistHumor.PublicarNoticia("Mejores chistes de la semana");

            revistDeporte.Desuscribir(user);

            revistDeporte.PublicarNoticia("Resultados de los partidos de la semana");

            Console.ReadKey();
        }
    }
}
