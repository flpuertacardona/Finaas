using Finaas.Web.Models.Academicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Actividad
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Grupo Grupo { get; set; }
        public string GrupoId { get; set; }
        public DateTime FechaActividad { get; set; }
        public CategoriasApropiacion CategoriaAprociacion { get; set; }
        public Programa Programa { get; set; }
        public string ProgrmaId { get; set; }
        public CategoriasActividad Categoria { get; set; }
        public Regulacion Regulacion { get; set; }
        public Financiacion Financiacion { get; set; }
        public string FinanciacionId { get; set; }
        public UnidadApoyo  UnidadApoyo { get; set; }
        public string ImageUrl { get; set; }

        // TODO: Change the path when publish
        public string ImagePath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://Finaas.azurewebsites.net{ImageUrl.Substring(1)}";
        public string Lugar { get; set; }
    }
}