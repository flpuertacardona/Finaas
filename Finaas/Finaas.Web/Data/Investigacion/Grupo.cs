using Finaas.Web.Models.Academicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Grupo
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Escuela Escuela { get; set; }
        public string EscuelaId { get; set; }
        public List<Cientifico> Cientificos { get; set; }
        public DateTime FechaApertura { get; set; }
    }
}