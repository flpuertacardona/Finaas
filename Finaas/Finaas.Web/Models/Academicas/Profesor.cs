using Finaas.Web.Models.Administrativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Profesor
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Empleado Empleado { get; set; }
        public string EmpleadoId { get; set; }
    }
}
