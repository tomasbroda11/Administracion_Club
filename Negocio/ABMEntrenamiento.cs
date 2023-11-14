using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ABMEntrenamiento
    {
        DatosEntrenamiento de = new DatosEntrenamiento();

        public Entrenamiento obtenerEntrenamientoXId(int id)
        {
            return de.obtenerEntrenamiento(id);
        }
        public bool ExisteEntrenamientoEnFechaYHora(int dia, TimeOnly horaDesde, TimeOnly horaHasta, Instalacion instalacion)
        {
            return de.ExisteEntrenamientoEnFechaYHora(dia, horaDesde ,horaHasta, instalacion);
        }

        public void CrearEntrenamiento(Entrenamiento entrenamiento)
        {
            de.CrearEntrenamiento(entrenamiento);
        }

        public List<Entrenamiento> ConsultarEntrenamientosPorInstalacionDiaYHora(int idInstalacion, int dia, TimeOnly hora)
        {
            return de.ConsultarEntrenamientosPorInstalacionDiaYHora(idInstalacion, dia, hora);
        }

        public List<Entrenamiento> ConsultarEntrenamientosProfesor(string dni)
        {
            return de.ConsultarEntrenamientosProfesor(dni);
        }

        public void actualizarEntrenamiento(Entrenamiento e)
        {
            de.updateEntrenamiento(e);
        }

        public void eliminarEntrenamiento(int id)
        {
            de.deleteEntrenamiento(id);
        }

    }
}
