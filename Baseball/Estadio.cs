using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Estadio
    {
        public string NombreEstadio { get; set; }
        public string Direccion { get; set; }
        public int Capacidad { get; set; }

        public Estadio()
        {
            NombreEstadio = "Nuevo Estadio";
            Direccion = "Direccion Nueva";
            Capacidad = 0;
        }

        public Estadio(string nombreEstadio, string direccion, int capacidad)
        {
            NombreEstadio = nombreEstadio;
            Direccion = direccion;
            Capacidad = capacidad;
        }
    }
}
