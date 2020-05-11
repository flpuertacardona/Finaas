using Finaas.Web.Models.Academicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Financiacion
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public FuentesRecursos FuenteRecursos { get; set; }
        public CategoriasRecursos CategoriasRecursos { get; set; }
        public Cultura Destinacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public float Valor { get; set; }
        public float Disponible { get; set; }
        public DateTime FechaDisponible { get; set; }
        public Grupo Grupo { get; set; }
        public string GrupoId { get; set; }
        public Escuela Escuela { get; set; }
        public Programa Programa { get; set; }
    }
}