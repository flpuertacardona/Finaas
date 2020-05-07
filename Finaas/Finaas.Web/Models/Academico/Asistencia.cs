using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academico
{
    public class Asistencia
    {
        public string Id { get; set; }
        public Profesor Profesor { get; set; }
        public string ProfesorId { get; set; }
        public Curso Curso { get; set; }
        public string CursoId { get; set; }
        public List<Alumno> Alumnos { get; set; }
    }
}
