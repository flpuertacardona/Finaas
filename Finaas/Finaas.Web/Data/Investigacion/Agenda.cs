using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Agenda
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public List<Actividad>  Actividades { get; set; }
        public DateTime FechaActividad { get; set; }
    }
}