using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Encuesta
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Resultados { get; set; }
        public string Url { get; set; }
        public CulturaConocimiento EjeConocimiento { get; set; }
        public GruposInvestigacion  GrupoInvestigacion { get; set; }
        public string GruposInvestigacionId { get; set; }
    }
}