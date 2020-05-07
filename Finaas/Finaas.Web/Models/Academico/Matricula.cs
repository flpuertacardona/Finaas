using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academico
{
    public class Matricula
    {
        public string Id { get; set; }
        public Alumno Alumno { get; set; }
        public string AlumnoId { get; set; }
        public string Periodo { get; set; }
        public DateTime FechaAdmision { get; set; }
        public Programa Programa { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public int CantidadCreditos { get; set; }
        public float Descuento { get; set; }
        public decimal ValorCredito { get; set; }
        public decimal ValorDescuento{ get; set; }
    }
}