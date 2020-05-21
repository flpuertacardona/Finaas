using Finaas.Web.Models.Academicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class MasterProject
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public List<Agenda> AgendasConocimiento { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public DateTime FechaIniciacion { get; set; }
        public float Presupuesto { get; set; }
        public string DisponibilidadPresupuestal { get; set; }
        public List<Financiacion> Financiaciones { get; set; }
        public UnidadApoyo UnidadApoyo { get; set; }
        public Regulacion Regulacion { get; set; }
        public CategoriaProyecto Categoria { get; set; }
        public SectorAplicacion Sector { get; set; }
        //TODO : modificar propiedad, para que almacene una lista de imagenes
        public string Imagenes { get; set; }
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
    }
}