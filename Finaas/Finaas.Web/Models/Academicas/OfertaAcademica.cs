using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class OfertaAcademica
    {
        public string Id { get; set; }
        public Escuela Escuela { get; set; }
        public Programa Programa { get; set; }
        public Asignatura Asignatura { get; set; }
        public int NumeroCreditos { get; set; }
        public decimal ValorCredito { get; set; }
    }
}
