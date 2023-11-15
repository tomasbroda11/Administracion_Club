using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Profesor : Persona
    {
        public Profesor(int dni, string nombre, string apellido, string mail, string password, string rol, Actividad actividad): base(dni, nombre, apellido, mail, password, "profesor")
        {
            this.Actividad = actividad; 
        }
        public Profesor() { }
        Actividad Actividad { get; set; }
        public Actividad getActividad()
        {
            return this.Actividad;
        }
    }
}