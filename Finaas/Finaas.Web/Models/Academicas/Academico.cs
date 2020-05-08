using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Academico
    {
        public string Id { get; set; }
        public string Periodo { get; set; }
        public Alumno Alumno { get; set; }
        public string AlumnoId { get; set; }
        public Asignatura Asignatura { get; set; }
        public Curso Curso { get; set; }
        public Seguimiento Seguimiento { get; set; }
        public float Porcentaje { get; set; }
        public float Nota { get; set; }
    }
}