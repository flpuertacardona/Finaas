using Finaas.Web.Models.Academicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Ejecucion
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Escuela Escuela { get; set; }
        public string EscuelaId { get; set; }
        public Grupo Grupo { get; set; }
        public string GrupoId { get; set; }
        public Cultura Cultura { get; set; }
        public string CulturaId { get; set; }
        public List<Agenda> AgendasConocimiento { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public DateTime FechaIniciacion { get; set; }
        public float Presupuesto { get; set; }
        public string DisponibilidadPresupuestal { get; set; }
        public Financiacion Financiacion { get; set; }
        public string FinanciacionId { get; set; }
        public List<UnidadApoyo> UnidadesApoyo { get; set; }
        public List<Regulacion> Regulacion { get; set; }
    }
}