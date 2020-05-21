using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string UrlResultados { get; set; }
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public string Revista { get; set; }
        public string ImageUrl { get; set; }

        // TODO: Change the path when publish
        public string ImagePath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://Finaas.azurewebsites.net{ImageUrl.Substring(1)}";
        public CategoriaPublicacion Categoria { get; set; }
    }
}