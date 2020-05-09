using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class ActividadesConocimiento
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public GruposInvestigacion GrupoInvestigacion { get; set; }
        public EjesConocimiento EjeConocimiento { get; set; }
        public DateTime FechaActividad { get; set; }
        public CategoriasApropiacion CategoriaAprociacion { get; set; }
    }
}