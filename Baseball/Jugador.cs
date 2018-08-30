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
        
        public Jugador()
        {
            NombreJugador = "Nuevo jugador";
            Numero = "Numero nuevo";
        }

        public Jugador(string nombreJugador, string numero)
        {
            NombreJugador = nombreJugador;
            Numero = numero;
        }


    }
}
