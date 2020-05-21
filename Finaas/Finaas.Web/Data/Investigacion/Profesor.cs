using Finaas.Web.Data.Investigacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Profesor
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public CategoriasPrograma Categoria { get; set; }
        public List<Programa> Programas { get; set; }
        public int? GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public Disciplina Conocimiento { get; set; }
        public CategoriaInvestigador CategoriaInvestigador { get; set; }
    }
}