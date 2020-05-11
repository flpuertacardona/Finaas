using Finaas.Web.Data.Investigacion;
using Finaas.Web.Models.Administrativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Profesor
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Empleado Empleado { get; set; }
        public string EmpleadoId { get; set; }
        public CategoriasPrograma Categoria { get; set; }
        public Escuela Escuela { get; set; }
        public string EscuelaId { get; set; }
        public List<Programa> Programas { get; set; }
        public Grupo Grupo { get; set; }
        public string GrupoId { get; set; }
        public Cultura Cultura { get; set; }
        public string CulturaId { get; set; }
    }
}
