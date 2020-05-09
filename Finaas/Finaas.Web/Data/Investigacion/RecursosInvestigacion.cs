using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class RecursosInvestigacion
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public FuentesRecursos FuenteRecursos { get; set; }
        public CategoriasRecursos CategoriasRecursos { get; set; }
        public EjesConocimiento Destinacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public float Valor { get; set; }
        public float Disponible { get; set; }
        public DateTime FechaDisponible { get; set; }
    }
}