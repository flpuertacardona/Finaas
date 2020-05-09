﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finaas.Web.Models.Academicas
{
    public class Programa
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public CategoriasProfesor Categoria { get; set; }
        public Escuela Escuela { get; set; }
        public string EscuelaId { get; set; }
        public List<Asignatura> Asignaturas { get; set; }


    }
}
