using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academico
{
    public class Seguimiento
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public float Porcentaje { get; set; }
        public Asignatura Asignatura { get; set; }
        public string AsignaturaId { get; set; }
        public Curso Curso { get; set; }
        public string CursoId { get; set; }
        public Programa Programa { get; set; }
        public string ProgramaId { get; set; }
    }
}