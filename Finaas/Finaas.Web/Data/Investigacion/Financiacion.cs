using Finaas.Web.Models.Academicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Financiacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public FuentesRecursos FuenteRecursos { get; set; }
        public CategoriasRecursos CategoriasRecursos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public float Valor { get; set; }
        public float Disponible { get; set; }
        public DateTime FechaDisponible { get; set; }
        public int EjecucionId { get; set; }
        public MasterProject Ejecucion { get; set; }
    }
}