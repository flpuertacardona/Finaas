using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Admision
    {
        public string Id { get; set; }
        public Alumno Alumno { get; set; }
        public string AlumnoId { get; set; }
        public string Periodo { get; set; }
        public DateTime FechaAdmision { get; set; }
        public Programa Programa { get; set; }
        public TiposAdmision TipoAdmision { get; set; }
    }
}
