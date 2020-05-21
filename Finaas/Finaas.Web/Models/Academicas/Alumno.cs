using Finaas.Web.Data.Investigacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Alumno
    {
        public string Id { get; set; }
        public string EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
        public List<Calificacion> Calificaciones { get; set; }
        public Programa Programa { get; set; }
        public string ProgramaId { get; set; }
    }
}