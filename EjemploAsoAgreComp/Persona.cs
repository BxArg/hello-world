using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploAsoAgreComp
{
    class Persona
    {
        //Relación de composición: hago el new dentro de la clase
        Domicilio dom = new Domicilio();

        //Relación de agregación: no hago el new, ya viene desde afuera resuelto.
        Categoria cat;
        public Persona(Categoria c)
        {
            cat = c;
        }

        //Atributos de la clase
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Id { get; set; }

        //Relación de dependencia: no forma parte de la clase, es utilizada para hacer alguna de sus operaciones
        public void Postularse()
        {
            Postulacion p = new Postulacion();
            p.Enviar();
        }
        
    }

   
}
