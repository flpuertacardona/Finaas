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
        public Profesor Profesor { get; set; }
        public string ProfesorId { get; set; }
        public EjesConocimiento EjeConocimiento { get; set; }
    }
}