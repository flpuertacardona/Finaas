using Finaas.Web.Data.Investigacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Boletin
    {
        public string Id { get; set; }
        public string Periodo { get; set; }
        public Alumno Alumno { get; set; }
        public string AlumnoId { get; set; }
        public Programa Programa { get; set; }
        public Asignatura Asignatura { get; set; }
        public string AsignaturaId { get; set; }
        public float Nota { get; set; }
        public int NumeroCreditos { get; set; }
    }
}
