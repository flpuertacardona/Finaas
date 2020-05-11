using Finaas.Web.Models.Academicas;
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
        public string GruposInvestigacionId { get; set; }
        public CulturaConocimiento CulturaConocimiento { get; set; }
        public DateTime FechaActividad { get; set; }
        public CategoriasApropiacion CategoriaAprociacion { get; set; }
        public Programa Programa { get; set; }
        public string ProgrmaId { get; set; }

    }
}