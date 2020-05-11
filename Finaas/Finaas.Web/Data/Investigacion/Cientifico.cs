using Finaas.Web.Models.Academicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Cientifico
    {
        public string Id { get; set; }
        public Conocimiento Conocimiento { get; set; }
        public Profesor Profesor { get; set; }
        public string ProfesorId { get; set; }
        public Cultura Cultura { get; set; }
        public string CulturaId { get; set; }
        public Grupo Grupo { get; set; }
        public string GrupoId { get; set; }
        public Escuela Escuela { get; set; }
        public string EscuelaId { get; set; }
    }
}