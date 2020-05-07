using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academico
{
    public class Curso
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Profesor Profesor { get; set; }
        public int Cupo { get; set; }
        public int Disponible { get; set; }
        public Programa Programa { get; set; }
        public bool Estado => {?Disponible > 0 true : falsepublic override bool Equals(object obj)
        {
            return obj is Curso curso &&
                   Estado == curso.Estado;
        }
    }
    }
}
