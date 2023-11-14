using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Instalacion
    {
        private int idInstalacion;
        private string descripcion;
        private int activo;

        public Instalacion(int iIdInstalacion, string iDescripcion, int iActivo, Actividad actividad)
        {
            idInstalacion = iIdInstalacion;
            descripcion = iDescripcion;
            activo = iActivo;
            Actividad = actividad;
        }

        public int getId()
        {
            return this.idInstalacion;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }

        public int getActivo()
        {
            return this.activo;
        }

        public Actividad Actividad { get; set; }
    }
}