using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Aula
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Curso> Cursos { get; set; }
        public int Cupos { get; set; }
        public int Disponible { get; set; }
        public bool Estado => (Disponible > 0) ? true : false;
    }
}
