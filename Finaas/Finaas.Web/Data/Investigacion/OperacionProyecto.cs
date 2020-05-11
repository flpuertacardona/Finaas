using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class OperacionProyecto
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public GruposInvestigacion GrupoInvestigacion { get; set; }
        public string GruposInvestigacionId { get; set; }
        public CulturaConocimiento CulturaConocimiento { get; set; }
        public List<AgendasConocimiento> AgendasConocimiento { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public DateTime FechaIniciacion { get; set; }
        public float Presupuesto { get; set; }
        public string DisponibilidadPresupuestal { get; set; }
        public FinanciacionProyecto Financiacion { get; set; }
        public List<UnidadApoyo> UnidadesApoyo { get; set; }
        public List<Regulacion> Regulacion { get; set; }
    }
}