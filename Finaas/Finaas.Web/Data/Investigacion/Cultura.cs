﻿using Finaas.Web.Models.Academicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Data.Investigacion
{
    public class Cultura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public AgendaConocimiento CulturaConocimiento { get; set; }
    }
}