using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploReglasNegocio
{
    class ReglaNegocio
    {
        public string descripcion;
        public string version;
        public string responsable;
        public DateTime fechaCreacion;
        public DateTime fechaModificacion;
        public List<Condicion> condiciones;
        public List<Advertencia> advertencias;
    }

    class ReporteReglas {
        public string nombreEscenario;
        public List<ReglaNegocio> ListaReglas;
    }
}