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
            List<Jugador> Jugadores = new List<Jugador>();

            Jugador jugador1 = new Jugador();
            jugador1.NombreJugador = "Julio";
            jugador1.Numero = "1";
            jugador1.Equipos.Add(new Equipo("Venados", "Culiacan", "Carlos Santa Ana", "9"));
            Jugadores.Add(jugador1);

            Jugador jugador2 = new Jugador();
            jugador2.NombreJugador = "Pancho";
            jugador2.Numero = "1";
            jugador2.Equipos.Add(new Equipo("Venados", "Culiacan", "Carlos Santa Ana", "9"));
            Jugadores.Add(jugador2);

            Jugador jugador3 = new Jugador();
            jugador3.NombreJugador = "Karla";
            jugador3.Numero = "3";
            jugador3.Equipos.Add(new Equipo("Venados", "Culiacan", "Carlos Santa Ana", "9"));
            Jugadores.Add(jugador3);

            Jugador jugador4 = new Jugador();
            jugador4.NombreJugador = "Juanjo";
            jugador4.Numero = "4";
            jugador4.Equipos.Add(new Equipo("Venados", "Culiacan", "Carlos Santa Ana", "9"));
            Jugadores.Add(jugador4);

            Jugador jugador5 = new Jugador();
            jugador5.NombreJugador = "Oscar";
            jugador5.Numero = "5";
            jugador5.Equipos.Add(new Equipo("Venados", "Culiacan", "Carlos Santa Ana", "9"));
            Jugadores.Add(jugador5);

            Jugador jugador6 = new Jugador();
            jugador6.NombreJugador = "Fabian";
            jugador6.Numero = "6";
            jugador6.Equipos.Add(new Equipo("Venados", "Culiacan", "Carlos Santa Ana", "9"));
            Jugadores.Add(jugador6);

            Jugador jugador7 = new Jugador();
            jugador7.NombreJugador = "Titha";
            jugador7.Numero = "7";
            jugador7.Equipos.Add(new Equipo("Venados", "Culiacan", "Carlos Santa Ana", "9"));
            Jugadores.Add(jugador7);

            Jugador jugador8 = new Jugador();
            jugador8.NombreJugador = "Nestor";
            jugador8.Numero = "8";
            jugador8.Equipos.Add(new Equipo("Venados", "Culiacan", "Carlos Santa Ana", "9"));
            Jugadores.Add(jugador8);

            Jugador jugador9 = new Jugador();
            jugador9.NombreJugador = "Jennifer";
            jugador9.Numero = "9";
            jugador9.Equipos.Add(new Equipo("Venados", "Culiacan", "Carlos Santa Ana", "9"));
            Jugadores.Add(jugador9);

            Jugador jugador10 = new Jugador();
            jugador10.NombreJugador = "Gerardo";
            jugador10.Numero = "1";
            jugador10.Equipos.Add(new Equipo("Yaquis", "Obregon", "Josh", "9"));
            Jugadores.Add(jugador10);

            Jugador jugador11 = new Jugador();
            jugador11.NombreJugador = "Fernando";
            jugador11.Numero = "2";
            jugador11.Equipos.Add(new Equipo("Yaquis", "Obregon", "Josh", "9"));
            Jugadores.Add(jugador11);

            Jugador jugador12 = new Jugador();
            jugador12.NombreJugador = "Ruben";
            jugador12.Numero = "3";
            jugador12.Equipos.Add(new Equipo("Yaquis", "Obregon", "Josh", "9"));
            Jugadores.Add(jugador12);

            Jugador jugador13 = new Jugador();
            jugador13.NombreJugador = "Andres";
            jugador13.Numero = "4";
            jugador13.Equipos.Add(new Equipo("Yaquis", "Obregon", "Josh", "9"));
            Jugadores.Add(jugador13);

            Jugador jugador14 = new Jugador();
            jugador14.NombreJugador = "Santiago";
            jugador14.Numero = "5";
            jugador14.Equipos.Add(new Equipo("Yaquis", "Obregon", "Josh", "9"));
            Jugadores.Add(jugador14);

            Jugador jugador15 = new Jugador();
            jugador15.NombreJugador = "Antolin";
            jugador15.Numero = "6";
            jugador15.Equipos.Add(new Equipo("Yaquis", "Obregon", "Josh", "9"));
            Jugadores.Add(jugador15);

            Jugador jugador16 = new Jugador();
            jugador16.NombreJugador = "Miguel";
            jugador16.Numero = "7";
            jugador16.Equipos.Add(new Equipo("Yaquis", "Obregon", "Josh", "9"));
            Jugadores.Add(jugador16);

            Jugador jugador17 = new Jugador();
            jugador17.NombreJugador = "Meza";
            jugador17.Numero = "8";
            jugador17.Equipos.Add(new Equipo("Yaquis", "Obregon", "Josh", "9"));
            Jugadores.Add(jugador17);

            Jugador jugador18 = new Jugador();
            jugador18.NombreJugador = "Estefanía";
            jugador18.Numero = "9";
            jugador18.Equipos.Add(new Equipo("Yaquis", "Obregon", "Josh", "9"));
            Jugadores.Add(jugador18);

            foreach (Jugador elemento in Jugadores)
            {
                Console.WriteLine("Jugador: " + elemento.NombreJugador);
                Console.WriteLine("Numero: " + elemento.Numero);
                foreach(Equipo equipo in elemento.Equipos)
                {
                    Console.WriteLine("Equipo: " + equipo.NombreEquipo);
                }
            }

            Console.ReadLine();
        }
    }
}
