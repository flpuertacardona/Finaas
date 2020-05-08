using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Promedio
    {
        public string Id { get; set; }
        public string Periodo { get; set; }
        public Alumno Alumno { get; set; }
        public string AlumnoId { get; set; }
        public Programa Programa { get; set; }
        public string ProgramaId { get; set; }
        public float Nota { get; set; }
    }
}
