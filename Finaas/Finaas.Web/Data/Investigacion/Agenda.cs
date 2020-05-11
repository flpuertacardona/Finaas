using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Agenda
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Grupo GrupoInvestigacion { get; set; }
        public string GruposInvestigacionId { get; set; }
        public Cultura Cultura { get; set; }
        public List<Actividad>  Actividades { get; set; }
        public DateTime FechaActividad { get; set; }
        public DateTime HoraActividad { get; set; }
        public float DuracionActividad { get; set; }
    }
}