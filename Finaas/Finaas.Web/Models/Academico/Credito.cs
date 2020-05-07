using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academico
{
    public class Credito
    {
        public string Id { get; set; }
        public Programa Programa { get; set; }
        public string ProgramaId { get; set; }
        public Asignatura Asignatura { get; set; }
        public string AsignaturaId { get; set; }
        public int Cantidad { get; set; }
    }
}
