using Finaas.Web.Data.Investigacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Asistencia
    {
        public string Id { get; set; }
        public Profesor Profesor { get; set; }
        public string ProfesorId { get; set; }
        public Curso Curso { get; set; }
        public string CursoId { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public DateTime FechaAsistencia { get; set; }
        public Asignatura Asignatura { get; set; }
        public string AsignaturaId { get; set; }

    }
}
