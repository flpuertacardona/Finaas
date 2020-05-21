using Finaas.Web.Data.Investigacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Evaluacion
    {
        public string Id { get; set; }
        public Asignatura Asignatura { get; set; }
        public string AsignaturaId { get; set; }
        public Alumno Alumno { get; set; }
        public string AlumnoId { get; set; }
        public Curso Curso { get; set; }
        public string CursoId { get; set; }
        public Seguimiento Seguimiento { get; set; }
        public float Nota { get; set; }
        public float porcentaje { get; set; }
    }
}
