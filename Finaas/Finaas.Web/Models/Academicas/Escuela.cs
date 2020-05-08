using Finaas.Web.Models.Administrativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Escuela
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Conocimiento Conocimiento { get; set; }
        public DateTime FechaApertura { get; set; }
        public Empleado Decano { get; set; }
    }
}
