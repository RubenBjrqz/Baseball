using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Equipo
    {
        public string NombreEquipo { get; set; }
        public string Ciudad { get; set; }
        public string Entrenador { get; set; }
        public string Jugadores { get; set; }

        public Equipo()
        {
            NombreEquipo = "Equipo nuevo";
            Ciudad = "Ciudad nueva";
            Entrenador = "Entrenador nuevo";
            Jugadores = "0";
        }

        public Equipo(string nombreEquipo, string ciudad, string entrenador, string jugadores)
        {
            NombreEquipo = nombreEquipo;
            Ciudad = ciudad;
            Entrenador = entrenador;
            Jugadores = jugadores;
        }

    }

}
