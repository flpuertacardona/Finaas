using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Cuadernillo
    {
        public string Id { get; set; }
        public string Periodo { get; set; }
        public Alumno Alumno { get; set; }
        public Programa Programa { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }
    }
}
