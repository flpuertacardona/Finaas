using Finaas.Web.Models.Academicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Actividad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int AgendaId { get; set; }
        public Agenda Agenda { get; set; }
        public DateTime FechaActividad { get; set; }
        public CategoriasApropiacion CategoriaAprociacion { get; set; }
        public int ProgrmaId { get; set; }
        public Programa Programa { get; set; }
        public CategoriasActividad Categoria { get; set; }
        public Regulacion Regulacion { get; set; }
        public UnidadApoyo  UnidadApoyo { get; set; }
        public string ImageUrl { get; set; }

        // TODO: Change the path when publish
        public string ImagePath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://Finaas.azurewebsites.net{ImageUrl.Substring(1)}";
        public string Lugar { get; set; }
        public int? PublicacionId { get; set; }
        public Publicacion Publicacion { get; set; }
        public CategoriaProyecto CategoriaProyecto { get; set; }
    }
}