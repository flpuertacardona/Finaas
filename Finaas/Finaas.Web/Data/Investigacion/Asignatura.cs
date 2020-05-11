using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Asignatura
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Escuela Escuela { get; set; }
        public string EscuelaId { get; set; }
        public List<Profesor> Profesores { get; set; }
    }
}
