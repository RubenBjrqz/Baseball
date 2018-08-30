using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> listaEquipos = new List<Equipo>();
            listaEquipos.Add(new Equipo());
            listaEquipos[0].estadio = new Estadio("Stadium", "Obregon", 60000);
            listaEquipos[0].NombreEquipo = "The team";
            listaEquipos[0].Jugadores.Add(new Jugador("asdasd", "12"));
            listaEquipos[0].Jugadores.Add(new Jugador("asdasd", "12"));
            listaEquipos[0].Jugadores.Add(new Jugador("asdasd", "12"));
            listaEquipos[0].Jugadores.Add(new Jugador("asdasd", "12"));
            listaEquipos[0].Jugadores.Add(new Jugador("asdasd", "12"));
            listaEquipos[0].Jugadores.Add(new Jugador("asdasd", "12"));
            listaEquipos[0].Jugadores.Add(new Jugador("asdasd", "12"));
            listaEquipos[0].Jugadores.Add(new Jugador("asdasd", "12"));
            listaEquipos[0].Jugadores.Add(new Jugador("asdasd", "12"));

            listaEquipos.Add(new Equipo());
            listaEquipos[1].NombreEquipo = "L'équipe";
            listaEquipos[0].estadio = new Estadio();
            listaEquipos[1].Jugadores.Add(new Jugador("asdasd", "13"));
            listaEquipos[1].Jugadores.Add(new Jugador("asdasd", "13"));
            listaEquipos[1].Jugadores.Add(new Jugador("asdasd", "13"));
            listaEquipos[1].Jugadores.Add(new Jugador("asdasd", "13"));
            listaEquipos[1].Jugadores.Add(new Jugador("asdasd", "13"));
            listaEquipos[1].Jugadores.Add(new Jugador("asdasd", "13"));
            listaEquipos[1].Jugadores.Add(new Jugador("asdasd", "13"));
            listaEquipos[1].Jugadores.Add(new Jugador("asdasd", "13"));

            foreach (Equipo elementoEquipo in listaEquipos)
            {
                Console.WriteLine("Nombre del Equipo: " + elementoEquipo.NombreEquipo);

                if(elementoEquipo.estadio.NombreEstadio != null)
                {
                    Console.WriteLine("Nombre del Estadio " + elementoEquipo.estadio.NombreEstadio);
                }
                else
                {
                    Console.WriteLine("No hay estadio");
                }

                foreach (Jugador elementoJugador in elementoEquipo.Jugadores)
                {
                    Console.WriteLine("Nombre del jugador: " + elementoJugador.NombreJugador);
                    Console.WriteLine("Numero del jugador: " + elementoJugador.Numero);
                }
            }

            Console.ReadLine();
        }
    }
}
