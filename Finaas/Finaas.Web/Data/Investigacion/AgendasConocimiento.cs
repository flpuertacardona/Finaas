using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class AgendasConocimiento
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public GruposInvestigacion GrupoInvestigacion { get; set; }
        public string GruposInvestigacionId { get; set; }
        public CulturaConocimiento EjeConociminento { get; set; }
        public CategoriasConocimiento  ActividadConocimiento { get; set; }
        public DateTime FechaActividad { get; set; }
        public DateTime HoraActividad { get; set; }
        public float DuracionActividad { get; set; }
        public string Documentacion { get; set; }
        public string Url { get; set; }
        public string Lugar { get; set; }
        public FinanciacionProyecto Financiacion { get; set; }
    }
}