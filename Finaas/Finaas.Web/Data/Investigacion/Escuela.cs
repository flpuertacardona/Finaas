using Finaas.Web.Models.Administrativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Escuela
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Conocimiento Conocimiento { get; set; }
        public DateTime FechaApertura { get; set; }
        public Profesor Decano { get; set; }
        public string ProfesorId { get; set; }
        public List<Programa> Programas { get; set; }
        public List<Cultura> Culturas { get; set; }
    }
}
