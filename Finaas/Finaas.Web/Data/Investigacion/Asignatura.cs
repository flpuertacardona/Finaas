using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Asignatura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int EscuelaId { get; set; }
        public Escuela Escuela { get; set; }
        public List<Profesor> Profesores { get; set; }
    }
}