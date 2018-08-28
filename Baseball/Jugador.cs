using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Jugador
    {
        public string NombreJugador { get; set; }
        public string Numero { get; set; }

        public List<Equipo> Equipos { get; set; }

        public Jugador()
        {
            Equipos = new List<Equipo>();

        }
    }
}
