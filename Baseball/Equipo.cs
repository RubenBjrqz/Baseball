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
        
        public List<Jugador> Jugadores { get; set; }
        public Estadio estadio { get; set; }

        public Equipo()
        {
            Jugadores = new List<Jugador>();
        }

    }

}
