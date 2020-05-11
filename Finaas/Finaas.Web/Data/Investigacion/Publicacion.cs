using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Publicacion
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string UrlResultados { get; set; }
        public CulturaConocimiento CulturaConocimiento { get; set; }
        public Grupo GrupoInvestigacion { get; set; }
        public string GruposInvestigacionId { get; set; }
        public string ImageUrl { get; set; }

        // TODO: Change the path when publish
        public string ImagePath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://Finaas.azurewebsites.net{ImageUrl.Substring(1)}";

    }
}