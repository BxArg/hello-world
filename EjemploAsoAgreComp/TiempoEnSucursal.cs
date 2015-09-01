using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploAsoAgreComp
{
    class TiempoEnSucursal
    {
        //Atributos relacionales
        public Sucursal Sucursal { get; set; }
        public Persona Persona { get; set; }

        //Atributos de la clase
        public DateTime FechaInico { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
