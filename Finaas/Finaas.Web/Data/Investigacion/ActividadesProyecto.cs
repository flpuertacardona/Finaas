using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class ActividadesProyecto
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public GruposInvestigacion GrupoInvestigacion { get; set; }
        public string GruposInvestigacionId { get; set; }
        public EjesConocimiento Ejeconocimiento { get; set; }
        public List<AgendasConocimiento> AgendasConocimiento { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public DateTime FechaIniciacion { get; set; }
        public float Presupuesto { get; set; }
        public string DisponibilidadPresupuestal { get; set; }
    }
}
